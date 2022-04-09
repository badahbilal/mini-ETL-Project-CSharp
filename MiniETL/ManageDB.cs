using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using System.Data; // pour l'utilisation de ConncetionState
using System.Data.SqlClient;
using MiniETL.models;

namespace MiniETL
{
    class ManageDB
    {

        //- Les Attributs des Objets de l'Ado.net 
        private SqlConnection cnx = null;
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader dr;

        public ManageDB()
        {
            this.cnx = new SqlConnection("data source=DESKTOP-J0LTV4T; initial catalog=miniETL; integrated security=true");

            this.Connection();
        }
        public ManageDB(string stringConnection)
        {
            this.cnx = new SqlConnection(stringConnection);

            this.Connection();
        }



        // Les methodes 
        private void Connection()
        {
            cmd.Connection = cnx;
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }
        }

        public string HashPassword(string pass)
        {
            
            byte[] raw = UTF8Encoding.UTF8.GetBytes(pass);

            byte[] hash;
            using (MD5 md5Hash = MD5.Create())
            {
                hash = md5Hash.ComputeHash(raw);
            }

            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sBuilder.Append(hash[i].ToString("x2"));

            return sBuilder.ToString();
        }


        public int createTable(string commande)
        {
            this.cmd.CommandText = commande;
            return this.cmd.ExecuteNonQuery();
            //cnx.Close();
        }
        // methodes d'insertion dans la base de données
        public int Ajouter(string commande)
        {
            this.cmd.CommandText = commande;
            return this.cmd.ExecuteNonQuery();
        }

        public int Verifier(string commande)
        {
            cmd.CommandText = commande;
            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public int Modifier(string commande)
        {
            this.cmd.CommandText = commande;
            return this.cmd.ExecuteNonQuery();
        }

        public int Supprimer(string commande)
        {
            this.cmd.CommandText = commande;
            return this.cmd.ExecuteNonQuery();
        }

        public List<Object> Rechercher(string commande, string tableName)
        {
            cmd.CommandText = commande;
            List<Object> ls = new List<Object>();
            dr = cmd.ExecuteReader(); 

            if(tableName == "user")
            {
                while (dr.Read()) { 
                    User u = new User();
                    u.Nom = (string)dr.GetValue(0);
                    u.Prenom = (string)dr.GetValue(1);
                    ls.Add(u);
                }
            }else if(tableName == "dbNames")
            {
                while (dr.Read())
                {
                    
                    string nameDB = (string)dr.GetValue(0);
                    ls.Add(nameDB);
                }
            }
            dr.Close();
            
            return ls;
        }
    }
}

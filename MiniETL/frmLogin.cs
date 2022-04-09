using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using MiniETL.models;

namespace MiniETL
{
    public partial class frmLogin : Form
    {
        
        private ManageDB manageDB;
        //private SqlDataReader drResult;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            manageDB = new ManageDB();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            string hashPass = manageDB.HashPassword(txtPassword.Text);

            string commande = "Select Count(*) from USERS where  Email like '" + txtLogin.Text + "' and Password like '" + hashPass+ "'";
            int count = manageDB.Verifier(commande);
            
            if (count == 1)
            {
                List<Object> ls;
                commande = "select Nom,Prenom  from USERS where  Email like '" + txtLogin.Text + "'";
                ls = manageDB.Rechercher(commande, "user");
                User u = (User)ls[0];

                MessageBox.Show("Bonjour Mr/Mme " + u.Nom + " " + u.Prenom + ".");

                UploadFiles uploadFile = new UploadFiles();
                UploadFiles.frmLogin = this;
                this.Hide();
                uploadFile.Show();
              }
            else
            {
                MessageBox.Show("les données inccorect");
                
            }
            

        }

        private void btnEffaceer_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Register frmRegister = new Register();
            frmRegister.Show();
            Register.frmLogin = this;
        }
    }
}

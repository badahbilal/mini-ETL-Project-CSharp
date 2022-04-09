using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniETL
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public static frmLogin frmLogin;
        private void button1_Click(object sender, EventArgs e)
        {
            ManageDB manageDB = new ManageDB(); 

            string cmd = "insert into USERS values ('"+   textBox1.Text +" ', '"+ textBox2.Text + " ', '" + textBox3.Text + " ', '" +manageDB.HashPassword(textBox4.Text) +"');";


            try
            {
                int count = manageDB.Ajouter(cmd);
                MessageBox.Show("L'utilisateur a bien été crée", "Créer nouveau utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Register.frmLogin.Visible = true;
                this.Close();
            }
            catch
            {
                MessageBox.Show("L'email est déja existe", "Charger un fichier", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            

            


        }
    }
}

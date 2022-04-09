using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiniETL.models;

namespace MiniETL
{
    public partial class UploadFiles : Form
    {

        List<String> champsNames = new List<string>();
        string sFileName;

        private ManageDB manageDB;
        // SqlDataReader drResult;

        public static frmLogin frmLogin;

        DataSet myDB = new DataSet("miniETL"); //  c'est le nom que je donne à ma base de données
        SqlConnection cnx = new SqlConnection(@"data source=DESKTOP-J0LTV4T; initial catalog=miniETL; integrated security=true");
        SqlDataAdapter daLOG;
        DataView dvf;

        public UploadFiles()
        {
            InitializeComponent();
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            bool loadIsGood = false;
            if (rdCSVFile.Checked)
            {
                openFileDialog1.Title = "CSV File to Edit";
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sFileName = openFileDialog1.FileName;
                    DataTable dt = new DataTable();
                    string[] lines = System.IO.File.ReadAllLines(sFileName);
                    if (lines.Length > 0)
                    {
                        //first line to create header
                        string firstLine = lines[0];
                        string[] headerLabels = firstLine.Split(',');
                        champsNames.Clear();
                        foreach (string headerWord in headerLabels)
                        {
                            champsNames.Add(headerWord);
                            dt.Columns.Add(new DataColumn(headerWord));
                        }
                        //For Data
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] dataWords = lines[i].Split(',');
                            DataRow dr = dt.NewRow();
                            int columnIndex = 0;
                            foreach (string headerWord in headerLabels)
                            {
                                dr[headerWord] = dataWords[columnIndex++];
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    loadIsGood = true;
                    tableCreated = false;
                    label1.Text = "Nombre de lignes : " + dt.Rows.Count;
                }
                
            }
            else
            {
                openFileDialog1.Title = "Excel File to Edit";
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    sFileName = openFileDialog1.FileName;
                    using (XLWorkbook workbook = new XLWorkbook(sFileName))
                    {
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();

                        foreach (var row in rows)
                        {
                            if (isFirstRow)
                            {
                                champsNames.Clear();
                                foreach (IXLCell cell in row.Cells()) { 
                                    champsNames.Add(cell.Value.ToString());
                                    dt.Columns.Add(cell.Value.ToString());
                                }
                                isFirstRow = false;

                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                {
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                                }
                            }
                            dataGridView1.DataSource = dt.DefaultView;
                            label1.Text = "nombre de lignes :" + dt.Rows.Count;
                        }
                    }
                    loadIsGood = true;
                    tableCreated = false;
                }
                
            }
            if (loadIsGood)
            {

                // label1.Text += " " +  champsNames.Count;

                dataGridView2.Rows.Clear();
                dataGridView2.ColumnCount = 1;
                dataGridView2.Columns[0].Name = "Nom du champ";
                //dataGridView2.Columns[1].Name = "type du champ";
                // dataGridView2.Columns[1].Name = " XY ";


                foreach (var champ in champsNames)
                {
                    string[] row = new string[] { champ };
                    dataGridView2.Rows.Add(row);
                }


                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.HeaderText = "type du champ";
                cmb.Name = "cmb";
                //cmb.MaxDropDownItems = 4;
                cmb.Items.Add("int");
                cmb.Items.Add("float");
                //cmb.Items.Add("decimal");
                cmb.Items.Add("varchar");
                cmb.Items.Add("date");
                cmb.Items.Add("datetime");
                //cmb.Items.Add("bool");
                dataGridView2.Columns.Add(cmb);

                DataGridViewTextBoxColumn text = new DataGridViewTextBoxColumn();
                //text.ReadOnly = false;


                dataGridView2.Columns.Add(text);
                dataGridView2.Rows[0].Cells[1].Value = "varchar";
                foreach (DataGridViewRow data in dataGridView2.Rows)
                {
                    data.Cells[1].Value = "varchar";
                    data.Cells[2].Value = "255";
                }

                string[] stringSeparators = new string[] { "\\" };
                string nameTable = sFileName.Split('.')[0].Split(stringSeparators, StringSplitOptions.None).Last();
                txtNameTable.Text = nameTable;
                lblDonnesCharger.Text = "Les donnnées du fichier : " + nameTable;
            }
        }

        private void UploadFiles_Load(object sender, EventArgs e)
        {
            daLOG = new SqlDataAdapter("select * from log", cnx);
            daLOG.Fill(myDB, "log");

            dvf = new DataView(myDB.Tables["log"]);
            dvf.Sort = "date_transfret desc";
            dataGridView3.DataSource = dvf;

            manageDB = new ManageDB();
            cbDBNames.DataSource = manageDB.Rechercher("SELECT name FROM sys.databases", "dbNames");
            cbDBNames.SelectedItem = "miniETL";
            
            //cbDBNames.SelectedValue = "miniETL";



        }

        private void UploadFiles_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                int rPos = e.ColumnIndex;
                int i = e.RowIndex;

                if (dataGridView2.Rows[i].Cells[rPos].Value.ToString() == "varchar" && e.ColumnIndex == 1)
                {
                    dataGridView2.Rows[i].Cells[rPos + 1].ReadOnly = false;
                    dataGridView2.Rows[i].Cells[rPos + 1].Value = "255";
                    dataGridView2.Rows[i].Cells[rPos + 1].Selected = true;
                }
                else if (dataGridView2.Rows[i].Cells[rPos].Value.ToString() != "varchar" && e.ColumnIndex == 1)
                {
                    dataGridView2.Rows[i].Cells[rPos + 1].Value = "";
                    dataGridView2.Rows[i].Cells[rPos + 1].ReadOnly = true;

                }

                if (e.ColumnIndex == 2 && dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                {
                    try
                    {
                        int a = -1;
                        if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                            a = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());


                        if (a > 255)
                        {
                            throw new Exception("La valeur maximum est 255");
                        }
                        else if (a <= 0)
                        {
                            throw new Exception("La valeur minimum est 1");
                        }


                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Valeur inacceptable");
                        MessageBox.Show(ex.Message);

                        dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "255";
                        dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    }
                }
            }
            catch
            {

            }



        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        bool tableCreated = false; 
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                manageDB = new ManageDB("data source=DESKTOP-J0LTV4T; initial catalog=" + cbDBNames.SelectedValue.ToString() + "; integrated security=true");
                string commande = "IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '" + txtNameTable.Text.Replace("-", "_") + "')) BEGIN drop table [" + txtNameTable.Text.Replace("-", "_") + " ];  END create table [" + txtNameTable.Text.Replace("-", "_") + " ](";
                string champs = "";

                try
                {
                    foreach (DataGridViewRow data in dataGridView2.Rows)
                    {
                        if (data.Cells[1].Value.ToString() == "varchar")
                        {
                            champs = champs + "[" + data.Cells[0].Value.ToString() + "] " + data.Cells[1].Value.ToString() + "(" + data.Cells[2].Value.ToString() + "),";
                        }
                        else
                        {
                            champs = champs + "[" +  data.Cells[0].Value.ToString() + "] " + data.Cells[1].Value.ToString() + ",";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                commande = commande + champs + ") ; ";
                // MessageBox.Show(commande);

                manageDB.createTable(commande);

                tableCreated = true;
                MessageBox.Show("La table a bien été crée", "Création de la table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez charger un fichier s'il vous plait", "Charger un fichier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl1.SelectedIndex = 0;
            }
           

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            if (dataGridView2.Rows.Count != 0)
            {
                if (tableCreated)
                {


                    int count = 0;

                    try
                    {
                        pBar.Minimum = 0;
                        pBar.Value = 0;
                        pBar.Maximum = dataGridView1.Rows.Count / 1000;
                        pBar.Maximum = pBar.Maximum == 0 ? 1 : pBar.Maximum ;

                        string cmd = "";

                        int countTo1000 = 0;
                        int countOfEnregistrement = dataGridView1.Rows.Count;
                        
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            count++;
                            if (countTo1000 == 0)
                            {
                                cmd = "insert into [" + txtNameTable.Text.Replace("-", "_") + "] values ";
                            }
                            countTo1000++;
                            cmd = cmd + "(";
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string value = cell.Value.ToString();
                                value = value.Replace("'", "''");
                                cmd = cmd + "'" + value + "',";
                            }
                            cmd = cmd.Remove(cmd.Length - 1, 1);
                            cmd = cmd + "),";
                            if (countTo1000 == 1000 || countOfEnregistrement == count)
                            {
                                cmd = cmd.Remove(cmd.Length - 1, 1);
                                cmd = cmd + ";";
                                countTo1000 = 0;
                                manageDB = new ManageDB("data source=DESKTOP-J0LTV4T; initial catalog=" + cbDBNames.SelectedValue.ToString() + "; integrated security=true");
                                int cou = manageDB.Ajouter(cmd);
                                cou++;
                                try
                                {
                                    pBar.Value += 1;
                                }
                                catch (Exception)
                                {
                                    pBar.Value  = pBar.Maximum;
                                    
                                }
                                
                            }

                            //pBar.Value += 1;
                        }




                        


                        DateTime myDateTime = DateTime.Now;
                        string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

                        myDB.Tables["log"].Rows.Add(/*txtNameTable.Text.Replace("-", "_")*/sFileName, sqlFormattedDate, count);


                        SqlCommandBuilder cb2 = new SqlCommandBuilder(daLOG);

                        daLOG.Update(myDB, "log");

                        MessageBox.Show("Les données ont bien été enregistrer", "Insértion des données", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tabControl1.SelectedIndex = 2;


                    }
                    catch (Exception )
                    {
                        MessageBox.Show("Veuillez vérifier les types des données s'il vous plait", "Rrreurs dans les types des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }





                    //string cmd = "";
                    
                    //int countTo1000 = 0;
                    //int countOfEnregistrement = dataGridView1.Rows.Count;
                    //int index = 0;
                    //foreach (DataGridViewRow row in dataGridView1.Rows)
                    //{
                    //    index++;
                    //    if(countTo1000 == 0)
                    //    {
                    //        cmd = "insert into " + txtNameTable.Text.Replace("-", "_") + " values ";
                    //    }
                    //    countTo1000++;
                    //    cmd = cmd + "(";
                    //    foreach(DataGridViewCell cell in  row.Cells)
                    //    {
                    //        string value = cell.Value.ToString();
                    //        value = value.Replace("'", "''");
                    //        cmd = cmd + "'" + value + "',";
                    //    }
                    //    cmd = cmd.Remove(cmd.Length - 1, 1);
                    //    cmd = cmd + "),";
                    //    if(countTo1000 == 1000 || countOfEnregistrement == index)
                    //    {
                    //        cmd = cmd.Remove(cmd.Length - 1, 1);
                    //        cmd = cmd + ";";
                    //        countTo1000 = 0;
                    //        manageDB = new ManageDB();
                    //        int cou = manageDB.Ajouter(cmd);
                    //        cou++;   
                    //    }
                    //}
                   

                    

                }
                else
                {
                    MessageBox.Show("Veuillez créer la table s'il vous plait", "Créer la table", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Veuillez charger un fichier s'il vous plait", "Charger un fichier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl1.SelectedIndex = 0;

            }


            dataGridView3.ClearSelection();
            dataGridView3.Rows[0].Selected = true;


        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

            if (dataGridView2.Rows.Count != 0)
            {
                if (checkBox1.Checked)
                {
                    txtNameTable.Enabled = true;
                }
                else
                {
                    txtNameTable.Enabled = false;
                }
            }
            else
            {
                checkBox1.Checked = false;
                MessageBox.Show("Veuillez charger un fichier s'il vous plait", "Charger un fichier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl1.SelectedIndex = 0;
            }
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            if (cxbCreateBD.Checked && txtDBName.Text.Trim().Length>0)
            {
                manageDB = new ManageDB();
                try
                {
                    manageDB.Ajouter("create database [" + txtDBName.Text + "]");
                    MessageBox.Show("La base de donées a bien été crée", "Création de la base de données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("La base de donées déja existe", "Déja existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                cbDBNames.DataSource = manageDB.Rechercher("SELECT name FROM sys.databases", "dbNames");
                cbDBNames.SelectedItem = txtDBName.Text;
                txtDBName.Enabled = false;
                txtDBName.Text = "";
                cxbCreateBD.Checked = false;
            }
        }

        private void cxbCreateBD_CheckedChanged(object sender, EventArgs e)
        {
            txtDBName.Enabled = cxbCreateBD.Checked ? true : false;
        }

        private void cxbChangerBD_CheckedChanged(object sender, EventArgs e)
        {
            cbDBNames.Enabled = cxbChangerBD.Checked ? true : false;
        }
    }
}

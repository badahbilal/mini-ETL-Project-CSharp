using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGridWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            //cmb.Items.Add("AAAA");
            //cmb.Items.Add("BBBB");
            //cmb.Items.Add("CCCC");

            //dataGridView1.Rows.Add("1st Col", "2nd Col");
            //dataGridView1.Columns.Add(cmb);

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Price";

            string[] row = new string[] { "1", "Product 1", "1000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "2", "Product 2", "2000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "3", "Product 3", "3000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "4", "Product 4", "4000" };
            dataGridView1.Rows.Add(row);

           

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Select Data";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 4;
            cmb.Items.Add("True 01");
            cmb.Items.Add("False 02");
            cmb.Items.Add("True 03 ");
            cmb.Items.Add("False 04");
            cmb.Items.Add("True 05 ");
            cmb.Items.Add("False 06");
            dataGridView1.Columns.Add(cmb);

            DataGridViewTextBoxColumn text = new DataGridViewTextBoxColumn();
            text.Visible = true;

            text.ReadOnly = true;

            dataGridView1.Columns.Add(text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();

            label1.Text = "";
            try
            {
                for (var i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    label1.Text = label1.Text + " " + dataGridView1.Rows[i].Cells[3].Value.ToString();
                }
            }
            catch
            {
                label1.Text = "error";
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           // label1.Text = "1";
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
           // label1.Text = "2";

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = "3";

            //var cell = sender as DataGridViewComboBoxCell;
            int rPos = dataGridView1.CurrentCell.ColumnIndex;
            int i = dataGridView1.CurrentRow.Index;

            label1.Text += " " + dataGridView1.Rows[i].Cells[rPos].Value.ToString();

            dataGridView1.Rows[i].Cells[rPos + 1].ReadOnly = false;





            //label1.Text = cell.Value.ToString();
        }
    }
}

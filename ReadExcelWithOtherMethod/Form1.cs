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

namespace ReadExcelWithOtherMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Excel File to Edit";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    sFileName = openFileDialog1.FileName;

            //    if (sFileName.Trim() != "")
            //    {
            //        readExcelDataGrid(sFileName);
            //    }
            //}
         // using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|* .xlsx", Multiselect = false })
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
               string  sFileName = openFileDialog1.FileName;
                using (XLWorkbook workbook = new XLWorkbook(sFileName))
                    {
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();

                        foreach (var row in rows)
                        {
                            if (isFirstRow)
                            {
                                foreach (IXLCell cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                isFirstRow = false;

                            }else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                {
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                                }
                            }
                            dataGridView1.DataSource = dt.DefaultView;
                        label1.Text = "nombre ligne :" + dt.Rows.Count;
                        }
                    }
                }
        }
    }
}

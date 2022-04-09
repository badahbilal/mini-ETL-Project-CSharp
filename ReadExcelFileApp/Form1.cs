using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ReadExcelFileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        string sFileName;
        int iRow, iCol = 2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Excel File to Edit";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFileName = openFileDialog1.FileName;

                if (sFileName.Trim() != "")
                {
                    readExcelDataGrid(sFileName);
                }
            }
        }

        private void readExcelCombo(string sFile)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(sFile);           // WORKBOOK TO OPEN THE EXCEL FILE.
            //xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];      // NAME OF THE SHEET.
            int countSheet = xlWorkBook.Worksheets.Count;
            List<string> excelSheets = new List<string>();


            int i = 0;
            foreach (Microsoft.Office.Interop.Excel.Worksheet wSheet in xlWorkBook.Worksheets)
            {
                excelSheets.Add(wSheet.Name);
                i++;
            }

            xlWorkSheet = xlWorkBook.Worksheets[excelSheets[0]];
            for (iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)  // START FROM THE SECOND ROW.
            {
                if (xlWorkSheet.Cells[iRow, 1].value == null)
                {
                    break;      // BREAK LOOP.
                }
                else
                {               // POPULATE COMBO BOX.
                    cmbEmp.Items.Add(xlWorkSheet.Cells[iRow, 1].value);
                }
            }

            xlWorkBook.Close();
            xlApp.Quit();
        }


        bool readCells = true;
        private void readExcelDataGrid(string sFile)
        {

            //dataGridView1.Rows.Clear();
            //dataGridView1.Colum
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

           xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(sFile);
            //xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];

            int countSheet = xlWorkBook.Worksheets.Count;
            List<string> excelSheets = new List<string>();


            int i = 0;
            foreach (Microsoft.Office.Interop.Excel.Worksheet wSheet in xlWorkBook.Worksheets)
            {
                excelSheets.Add(wSheet.Name);
                i++;
            }

            xlWorkSheet = xlWorkBook.Worksheets[excelSheets[0]];
            int nbCells = xlWorkSheet.Columns.Count;
            // FIRST, CREATE THE DataGridView COLUMN HEADERS.
            int iCol;
            for (iCol = 1; iCol <= nbCells; iCol++)
            {
                if (xlWorkSheet.Cells[1, iCol].value == null)
                {
                    break;      // BREAK LOOP.
                }
                else
                {
                    DataGridViewColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = xlWorkSheet.Cells[1, iCol].value;
                    dataGridView1.Columns.Add(col);     // ADD A NEW COLUMN.
                }
            }

            //ADD ROWS TO THE GRID.
            for (iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)  // START FROM THE SECOND ROW.
            {
                if (xlWorkSheet.Cells[iRow, 1].value == null)
                {
                    break;      // BREAK LOOP.
                }
                else
                {
                    // CREATE A STRING ARRAY USING THE VALUES IN EACH ROW OF THE SHEET.
                //    string[] row = new string[] { xlWorkSheet.Cells[iRow, 1].value,
                //xlWorkSheet.Cells[iRow, 2].value.ToString(),
                //xlWorkSheet.Cells[iRow, 3].value };
                    List<string> lsValus = new List<string>();
                    for(int j =1; j<= nbCells;  j++)
                    {
                        if (xlWorkSheet.Cells[iRow, j].value == null)
                        {
                            break;      // BREAK LOOP.
                        }
                        lsValus.Add(xlWorkSheet.Cells[iRow, j].value.ToString());
                    }

                    // ADD A NEW ROW TO THE GRID USING THE ARRAY DATA.
                    //dataGridView1.Rows.Add(row);

                    dataGridView1.Rows.Add(lsValus.ToArray());
                }
            }

            // ADD ROWS TO THE GRID.
            // int nbCells = 0;
            //if (readCells)
            // {
            //     nbCells = xlWorkSheet.Cells.Count;
            //     readCells = false;
            // }
            // for (iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)  // START FROM THE SECOND ROW.
            // {
            //     if (xlWorkSheet.Cells[iRow, 1].value == null)
            //     {
            //         break;      // BREAK LOOP.
            //     }
            //     else
            //     {
            //         // CREATE A STRING ARRAY USING THE VALUES IN EACH ROW OF THE SHEET.


            //         string[] row = new string[nbCells];

            //         for (int j = 0; i < nbCells; j++)
            //         {
            //             row[j] = xlWorkSheet.Cells[iRow, (i + 1)].Value.ToString(0);
            //         }

            //         // ADD A NEW ROW TO THE GRID USING THE ARRAY DATA.
            //         dataGridView1.Rows.Add(row);
            //     }
            // }

            xlWorkBook.Close();
            xlApp.Quit();

            //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
        }
    }
}

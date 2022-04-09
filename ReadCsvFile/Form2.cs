using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadCsvFile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pBar.Minimum = 0;
            pBar.Maximum = 100;
            pBar.Value = 70;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            pBar.Value += 10;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

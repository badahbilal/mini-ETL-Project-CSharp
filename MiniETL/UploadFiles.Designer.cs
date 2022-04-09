namespace MiniETL
{
    partial class UploadFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDonnesCharger = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCharger = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdExcelFile = new System.Windows.Forms.RadioButton();
            this.rdCSVFile = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.cbDBNames = new System.Windows.Forms.ComboBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtNameTable = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cxbChangerBD = new System.Windows.Forms.CheckBox();
            this.cxbCreateBD = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.lblDonnesCharger);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnCharger);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1037, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Charger les données";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblDonnesCharger
            // 
            this.lblDonnesCharger.AutoSize = true;
            this.lblDonnesCharger.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonnesCharger.Location = new System.Drawing.Point(152, 12);
            this.lblDonnesCharger.Name = "lblDonnesCharger";
            this.lblDonnesCharger.Size = new System.Drawing.Size(223, 22);
            this.lblDonnesCharger.TabIndex = 8;
            this.lblDonnesCharger.Text = "Les donnnées du fichier :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de lignes : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(871, 506);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(17, 159);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(114, 30);
            this.btnCharger.TabIndex = 5;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdExcelFile);
            this.groupBox1.Controls.Add(this.rdCSVFile);
            this.groupBox1.Location = new System.Drawing.Point(16, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type du fichier";
            // 
            // rdExcelFile
            // 
            this.rdExcelFile.AutoSize = true;
            this.rdExcelFile.Location = new System.Drawing.Point(22, 63);
            this.rdExcelFile.Name = "rdExcelFile";
            this.rdExcelFile.Size = new System.Drawing.Size(59, 17);
            this.rdExcelFile.TabIndex = 1;
            this.rdExcelFile.TabStop = true;
            this.rdExcelFile.Text = "EXCEL";
            this.rdExcelFile.UseVisualStyleBackColor = true;
            // 
            // rdCSVFile
            // 
            this.rdCSVFile.AutoSize = true;
            this.rdCSVFile.Checked = true;
            this.rdCSVFile.Location = new System.Drawing.Point(22, 30);
            this.rdCSVFile.Name = "rdCSVFile";
            this.rdCSVFile.Size = new System.Drawing.Size(46, 17);
            this.rdCSVFile.TabIndex = 0;
            this.rdCSVFile.TabStop = true;
            this.rdCSVFile.Text = "CSV";
            this.rdCSVFile.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1037, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Définir les types des champs";
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(6, 96);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(165, 42);
            this.btnCreateDB.TabIndex = 11;
            this.btnCreateDB.Text = "Créer une base de données";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // txtDBName
            // 
            this.txtDBName.Enabled = false;
            this.txtDBName.Location = new System.Drawing.Point(6, 60);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(165, 20);
            this.txtDBName.TabIndex = 10;
            // 
            // cbDBNames
            // 
            this.cbDBNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBNames.Enabled = false;
            this.cbDBNames.FormattingEnabled = true;
            this.cbDBNames.Location = new System.Drawing.Point(6, 19);
            this.cbDBNames.Name = "cbDBNames";
            this.cbDBNames.Size = new System.Drawing.Size(165, 21);
            this.cbDBNames.TabIndex = 9;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(6, 98);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(288, 26);
            this.pBar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "La gestion  BD et Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Déterminer le type des champs";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(6, 37);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(165, 42);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insérer les données";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(6, 88);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(165, 42);
            this.btnCreateTable.TabIndex = 4;
            this.btnCreateTable.Text = "Créer la table dans la BD";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Le nom de la table";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(194, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Changer le nom";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // txtNameTable
            // 
            this.txtNameTable.Enabled = false;
            this.txtNameTable.Location = new System.Drawing.Point(6, 51);
            this.txtNameTable.Name = "txtNameTable";
            this.txtNameTable.Size = new System.Drawing.Size(165, 20);
            this.txtNameTable.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(349, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(678, 490);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1037, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Toutes les transactions";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 59);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1025, 493);
            this.dataGridView3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cxbCreateBD);
            this.groupBox2.Controls.Add(this.cxbChangerBD);
            this.groupBox2.Controls.Add(this.btnCreateDB);
            this.groupBox2.Controls.Add(this.cbDBNames);
            this.groupBox2.Controls.Add(this.txtDBName);
            this.groupBox2.Location = new System.Drawing.Point(22, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 144);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choisir la base de données";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCreateTable);
            this.groupBox3.Controls.Add(this.txtNameTable);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(22, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 164);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Créer la table";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInsert);
            this.groupBox4.Controls.Add(this.pBar);
            this.groupBox4.Location = new System.Drawing.Point(22, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 138);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Insérer les données";
            // 
            // cxbChangerBD
            // 
            this.cxbChangerBD.AutoSize = true;
            this.cxbChangerBD.Location = new System.Drawing.Point(194, 19);
            this.cxbChangerBD.Name = "cxbChangerBD";
            this.cxbChangerBD.Size = new System.Drawing.Size(94, 17);
            this.cxbChangerBD.TabIndex = 5;
            this.cxbChangerBD.Text = "Choisir la base";
            this.cxbChangerBD.UseVisualStyleBackColor = true;
            this.cxbChangerBD.CheckedChanged += new System.EventHandler(this.cxbChangerBD_CheckedChanged);
            // 
            // cxbCreateBD
            // 
            this.cxbCreateBD.AutoSize = true;
            this.cxbCreateBD.Location = new System.Drawing.Point(194, 60);
            this.cxbCreateBD.Name = "cxbCreateBD";
            this.cxbCreateBD.Size = new System.Drawing.Size(88, 17);
            this.cxbCreateBD.TabIndex = 12;
            this.cxbCreateBD.Text = "Créer la base";
            this.cxbCreateBD.UseVisualStyleBackColor = true;
            this.cxbCreateBD.CheckedChanged += new System.EventHandler(this.cxbCreateBD_CheckedChanged);
            // 
            // UploadFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 589);
            this.Controls.Add(this.tabControl1);
            this.Name = "UploadFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion ETL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UploadFiles_FormClosed);
            this.Load += new System.EventHandler(this.UploadFiles_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdExcelFile;
        private System.Windows.Forms.RadioButton rdCSVFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtNameTable;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDonnesCharger;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.ComboBox cbDBNames;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cxbCreateBD;
        private System.Windows.Forms.CheckBox cxbChangerBD;
    }
}
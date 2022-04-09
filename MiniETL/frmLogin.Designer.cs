namespace MiniETL
{
    partial class frmLogin
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEffaceer = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(163, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(163, 72);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOGIN";
            // 
            // btnEffaceer
            // 
            this.btnEffaceer.Location = new System.Drawing.Point(128, 192);
            this.btnEffaceer.Name = "btnEffaceer";
            this.btnEffaceer.Size = new System.Drawing.Size(84, 38);
            this.btnEffaceer.TabIndex = 7;
            this.btnEffaceer.Text = "EFFACER";
            this.btnEffaceer.UseVisualStyleBackColor = true;
            this.btnEffaceer.Click += new System.EventHandler(this.btnEffaceer_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(87, 148);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(84, 38);
            this.btnConnection.TabIndex = 6;
            this.btnConnection.Text = "CONNEXION";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(179, 148);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(84, 38);
            this.btnInscrire.TabIndex = 12;
            this.btnInscrire.Text = "S\'INSCRIRE";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 258);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEffaceer);
            this.Controls.Add(this.btnConnection);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEffaceer;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnInscrire;
    }
}


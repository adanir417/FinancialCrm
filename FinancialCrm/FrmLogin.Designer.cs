namespace FinancialCrm
{
    partial class FrmLogin
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
            this.button_Login_Enter = new System.Windows.Forms.Button();
            this.lbl_Login_UserName = new System.Windows.Forms.Label();
            this.lbl_Login_Password = new System.Windows.Forms.Label();
            this.lbl_Login_Warning = new System.Windows.Forms.Label();
            this.textBox_Login_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Login_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Login_Enter
            // 
            this.button_Login_Enter.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.button_Login_Enter.Location = new System.Drawing.Point(469, 376);
            this.button_Login_Enter.Name = "button_Login_Enter";
            this.button_Login_Enter.Size = new System.Drawing.Size(209, 71);
            this.button_Login_Enter.TabIndex = 0;
            this.button_Login_Enter.Text = "Giriş";
            this.button_Login_Enter.UseVisualStyleBackColor = true;
            this.button_Login_Enter.Click += new System.EventHandler(this.button_Login_Enter_Click);
            // 
            // lbl_Login_UserName
            // 
            this.lbl_Login_UserName.AutoSize = true;
            this.lbl_Login_UserName.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Login_UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Login_UserName.Location = new System.Drawing.Point(461, 130);
            this.lbl_Login_UserName.Name = "lbl_Login_UserName";
            this.lbl_Login_UserName.Size = new System.Drawing.Size(218, 45);
            this.lbl_Login_UserName.TabIndex = 3;
            this.lbl_Login_UserName.Text = "Kullanıcı Adı:";
            // 
            // lbl_Login_Password
            // 
            this.lbl_Login_Password.AutoSize = true;
            this.lbl_Login_Password.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Login_Password.Location = new System.Drawing.Point(461, 233);
            this.lbl_Login_Password.Name = "lbl_Login_Password";
            this.lbl_Login_Password.Size = new System.Drawing.Size(100, 45);
            this.lbl_Login_Password.TabIndex = 4;
            this.lbl_Login_Password.Text = "Şifre:";
            // 
            // lbl_Login_Warning
            // 
            this.lbl_Login_Warning.AutoSize = true;
            this.lbl_Login_Warning.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Warning.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Login_Warning.Location = new System.Drawing.Point(472, 472);
            this.lbl_Login_Warning.Name = "lbl_Login_Warning";
            this.lbl_Login_Warning.Size = new System.Drawing.Size(0, 26);
            this.lbl_Login_Warning.TabIndex = 5;
            // 
            // textBox_Login_UserName
            // 
            this.textBox_Login_UserName.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.textBox_Login_UserName.Location = new System.Drawing.Point(469, 189);
            this.textBox_Login_UserName.Multiline = true;
            this.textBox_Login_UserName.Name = "textBox_Login_UserName";
            this.textBox_Login_UserName.Size = new System.Drawing.Size(209, 34);
            this.textBox_Login_UserName.TabIndex = 8;
            // 
            // textBox_Login_Password
            // 
            this.textBox_Login_Password.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.textBox_Login_Password.Location = new System.Drawing.Point(470, 303);
            this.textBox_Login_Password.Multiline = true;
            this.textBox_Login_Password.Name = "textBox_Login_Password";
            this.textBox_Login_Password.Size = new System.Drawing.Size(209, 34);
            this.textBox_Login_Password.TabIndex = 9;
            this.textBox_Login_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Login_Password_KeyDown);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.textBox_Login_Password);
            this.Controls.Add(this.textBox_Login_UserName);
            this.Controls.Add(this.lbl_Login_Warning);
            this.Controls.Add(this.lbl_Login_Password);
            this.Controls.Add(this.lbl_Login_UserName);
            this.Controls.Add(this.button_Login_Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinancialCRM - Giriş Ekranı";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login_Enter;
        private System.Windows.Forms.Label lbl_Login_UserName;
        private System.Windows.Forms.Label lbl_Login_Password;
        private System.Windows.Forms.Label lbl_Login_Warning;
        private System.Windows.Forms.TextBox textBox_Login_UserName;
        private System.Windows.Forms.TextBox textBox_Login_Password;
    }
}
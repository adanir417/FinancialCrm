namespace FinancialCrm
{
    partial class FrmSettings
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
            this.lbl_Settings_SettingsTitle = new System.Windows.Forms.Label();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Dashboard = new System.Windows.Forms.Button();
            this.button_BankProcess = new System.Windows.Forms.Button();
            this.button_Spendings = new System.Windows.Forms.Button();
            this.button_Bills = new System.Windows.Forms.Button();
            this.button_banks = new System.Windows.Forms.Button();
            this.button_Categories = new System.Windows.Forms.Button();
            this.dataGridView_Settings_UsersList = new System.Windows.Forms.DataGridView();
            this.lbl_Settings_UserNameTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Settings_Username = new System.Windows.Forms.TextBox();
            this.textBox_Settings_Password = new System.Windows.Forms.TextBox();
            this.button_Settings_AddUser = new System.Windows.Forms.Button();
            this.textBox_Settings_UserID = new System.Windows.Forms.TextBox();
            this.lbl_Settings_UserIDTitle = new System.Windows.Forms.Label();
            this.button_Settings_DeleteUser = new System.Windows.Forms.Button();
            this.lbl_Settings_Description = new System.Windows.Forms.Label();
            this.lbl_Settings_Warning = new System.Windows.Forms.Label();
            this.panel_Title.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Settings_UsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Settings_SettingsTitle
            // 
            this.lbl_Settings_SettingsTitle.AutoSize = true;
            this.lbl_Settings_SettingsTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings_SettingsTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Settings_SettingsTitle.Location = new System.Drawing.Point(14, 7);
            this.lbl_Settings_SettingsTitle.Name = "lbl_Settings_SettingsTitle";
            this.lbl_Settings_SettingsTitle.Size = new System.Drawing.Size(112, 39);
            this.lbl_Settings_SettingsTitle.TabIndex = 0;
            this.lbl_Settings_SettingsTitle.Text = "Ayarlar";
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.DarkBlue;
            this.panel_Title.Controls.Add(this.lbl_Settings_SettingsTitle);
            this.panel_Title.Location = new System.Drawing.Point(-1, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(2000, 49);
            this.panel_Title.TabIndex = 3;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel_Buttons.Controls.Add(this.button_Exit);
            this.panel_Buttons.Controls.Add(this.button_Settings);
            this.panel_Buttons.Controls.Add(this.button_Dashboard);
            this.panel_Buttons.Controls.Add(this.button_BankProcess);
            this.panel_Buttons.Controls.Add(this.button_Spendings);
            this.panel_Buttons.Controls.Add(this.button_Bills);
            this.panel_Buttons.Controls.Add(this.button_banks);
            this.panel_Buttons.Controls.Add(this.button_Categories);
            this.panel_Buttons.Location = new System.Drawing.Point(0, 49);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(226, 2000);
            this.panel_Buttons.TabIndex = 4;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Exit.Location = new System.Drawing.Point(14, 354);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(194, 43);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Çıkış Yap";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Settings
            // 
            this.button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Settings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Settings.Location = new System.Drawing.Point(14, 305);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(194, 43);
            this.button_Settings.TabIndex = 7;
            this.button_Settings.Text = "Ayarlar";
            this.button_Settings.UseVisualStyleBackColor = false;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_Dashboard
            // 
            this.button_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.button_Dashboard.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Dashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Dashboard.Location = new System.Drawing.Point(14, 256);
            this.button_Dashboard.Name = "button_Dashboard";
            this.button_Dashboard.Size = new System.Drawing.Size(194, 43);
            this.button_Dashboard.TabIndex = 6;
            this.button_Dashboard.Text = "Dashboard";
            this.button_Dashboard.UseVisualStyleBackColor = false;
            this.button_Dashboard.Click += new System.EventHandler(this.button_Dashboard_Click);
            // 
            // button_BankProcess
            // 
            this.button_BankProcess.BackColor = System.Drawing.Color.Transparent;
            this.button_BankProcess.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_BankProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_BankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BankProcess.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_BankProcess.Location = new System.Drawing.Point(14, 207);
            this.button_BankProcess.Name = "button_BankProcess";
            this.button_BankProcess.Size = new System.Drawing.Size(194, 43);
            this.button_BankProcess.TabIndex = 5;
            this.button_BankProcess.Text = "Banka Hareketleri";
            this.button_BankProcess.UseVisualStyleBackColor = false;
            this.button_BankProcess.Click += new System.EventHandler(this.button_BankProcess_Click);
            // 
            // button_Spendings
            // 
            this.button_Spendings.BackColor = System.Drawing.Color.Transparent;
            this.button_Spendings.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_Spendings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_Spendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Spendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Spendings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Spendings.Location = new System.Drawing.Point(14, 158);
            this.button_Spendings.Name = "button_Spendings";
            this.button_Spendings.Size = new System.Drawing.Size(194, 43);
            this.button_Spendings.TabIndex = 4;
            this.button_Spendings.Text = "Giderler";
            this.button_Spendings.UseVisualStyleBackColor = false;
            this.button_Spendings.Click += new System.EventHandler(this.button_Spendings_Click);
            // 
            // button_Bills
            // 
            this.button_Bills.BackColor = System.Drawing.Color.Transparent;
            this.button_Bills.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_Bills.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_Bills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Bills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Bills.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Bills.Location = new System.Drawing.Point(14, 109);
            this.button_Bills.Name = "button_Bills";
            this.button_Bills.Size = new System.Drawing.Size(194, 43);
            this.button_Bills.TabIndex = 3;
            this.button_Bills.Text = "Faturalar";
            this.button_Bills.UseVisualStyleBackColor = false;
            this.button_Bills.Click += new System.EventHandler(this.button_Bills_Click);
            // 
            // button_banks
            // 
            this.button_banks.BackColor = System.Drawing.Color.Transparent;
            this.button_banks.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_banks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_banks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_banks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_banks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_banks.Location = new System.Drawing.Point(14, 60);
            this.button_banks.Name = "button_banks";
            this.button_banks.Size = new System.Drawing.Size(194, 43);
            this.button_banks.TabIndex = 2;
            this.button_banks.Text = "Bankalar";
            this.button_banks.UseVisualStyleBackColor = false;
            this.button_banks.Click += new System.EventHandler(this.button_banks_Click);
            // 
            // button_Categories
            // 
            this.button_Categories.BackColor = System.Drawing.Color.Transparent;
            this.button_Categories.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.button_Categories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Categories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Categories.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Categories.Location = new System.Drawing.Point(14, 11);
            this.button_Categories.Name = "button_Categories";
            this.button_Categories.Size = new System.Drawing.Size(194, 43);
            this.button_Categories.TabIndex = 1;
            this.button_Categories.Text = "Kategoriler";
            this.button_Categories.UseVisualStyleBackColor = false;
            this.button_Categories.Click += new System.EventHandler(this.button_Categories_Click);
            // 
            // dataGridView_Settings_UsersList
            // 
            this.dataGridView_Settings_UsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Settings_UsersList.Location = new System.Drawing.Point(749, 55);
            this.dataGridView_Settings_UsersList.Name = "dataGridView_Settings_UsersList";
            this.dataGridView_Settings_UsersList.Size = new System.Drawing.Size(423, 694);
            this.dataGridView_Settings_UsersList.TabIndex = 5;
            // 
            // lbl_Settings_UserNameTitle
            // 
            this.lbl_Settings_UserNameTitle.AutoSize = true;
            this.lbl_Settings_UserNameTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings_UserNameTitle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Settings_UserNameTitle.Location = new System.Drawing.Point(231, 100);
            this.lbl_Settings_UserNameTitle.Name = "lbl_Settings_UserNameTitle";
            this.lbl_Settings_UserNameTitle.Size = new System.Drawing.Size(191, 39);
            this.lbl_Settings_UserNameTitle.TabIndex = 6;
            this.lbl_Settings_UserNameTitle.Text = "Kullanıcı Adı: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(323, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şifre : ";
            // 
            // textBox_Settings_Username
            // 
            this.textBox_Settings_Username.Location = new System.Drawing.Point(421, 109);
            this.textBox_Settings_Username.Name = "textBox_Settings_Username";
            this.textBox_Settings_Username.Size = new System.Drawing.Size(269, 20);
            this.textBox_Settings_Username.TabIndex = 8;
            // 
            // textBox_Settings_Password
            // 
            this.textBox_Settings_Password.Location = new System.Drawing.Point(421, 158);
            this.textBox_Settings_Password.Name = "textBox_Settings_Password";
            this.textBox_Settings_Password.PasswordChar = '*';
            this.textBox_Settings_Password.Size = new System.Drawing.Size(269, 20);
            this.textBox_Settings_Password.TabIndex = 9;
            // 
            // button_Settings_AddUser
            // 
            this.button_Settings_AddUser.BackColor = System.Drawing.Color.Lime;
            this.button_Settings_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings_AddUser.Location = new System.Drawing.Point(421, 205);
            this.button_Settings_AddUser.Name = "button_Settings_AddUser";
            this.button_Settings_AddUser.Size = new System.Drawing.Size(119, 32);
            this.button_Settings_AddUser.TabIndex = 10;
            this.button_Settings_AddUser.Text = "Kullanıcı Ekle";
            this.button_Settings_AddUser.UseVisualStyleBackColor = false;
            this.button_Settings_AddUser.Click += new System.EventHandler(this.button_Settings_AddUser_Click);
            // 
            // textBox_Settings_UserID
            // 
            this.textBox_Settings_UserID.Location = new System.Drawing.Point(421, 60);
            this.textBox_Settings_UserID.Name = "textBox_Settings_UserID";
            this.textBox_Settings_UserID.Size = new System.Drawing.Size(269, 20);
            this.textBox_Settings_UserID.TabIndex = 12;
            // 
            // lbl_Settings_UserIDTitle
            // 
            this.lbl_Settings_UserIDTitle.AutoSize = true;
            this.lbl_Settings_UserIDTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings_UserIDTitle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Settings_UserIDTitle.Location = new System.Drawing.Point(246, 51);
            this.lbl_Settings_UserIDTitle.Name = "lbl_Settings_UserIDTitle";
            this.lbl_Settings_UserIDTitle.Size = new System.Drawing.Size(176, 39);
            this.lbl_Settings_UserIDTitle.TabIndex = 11;
            this.lbl_Settings_UserIDTitle.Text = "Kullanıcı ID: ";
            // 
            // button_Settings_DeleteUser
            // 
            this.button_Settings_DeleteUser.BackColor = System.Drawing.Color.Red;
            this.button_Settings_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings_DeleteUser.Location = new System.Drawing.Point(571, 205);
            this.button_Settings_DeleteUser.Name = "button_Settings_DeleteUser";
            this.button_Settings_DeleteUser.Size = new System.Drawing.Size(119, 32);
            this.button_Settings_DeleteUser.TabIndex = 13;
            this.button_Settings_DeleteUser.Text = "Kullanıcı Sil";
            this.button_Settings_DeleteUser.UseVisualStyleBackColor = false;
            this.button_Settings_DeleteUser.Click += new System.EventHandler(this.button_Settings_DeleteUser_Click);
            // 
            // lbl_Settings_Description
            // 
            this.lbl_Settings_Description.AutoSize = true;
            this.lbl_Settings_Description.Location = new System.Drawing.Point(250, 361);
            this.lbl_Settings_Description.Name = "lbl_Settings_Description";
            this.lbl_Settings_Description.Size = new System.Drawing.Size(10, 13);
            this.lbl_Settings_Description.TabIndex = 14;
            this.lbl_Settings_Description.Text = "-";
            // 
            // lbl_Settings_Warning
            // 
            this.lbl_Settings_Warning.AutoSize = true;
            this.lbl_Settings_Warning.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings_Warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_Settings_Warning.Location = new System.Drawing.Point(250, 272);
            this.lbl_Settings_Warning.Name = "lbl_Settings_Warning";
            this.lbl_Settings_Warning.Size = new System.Drawing.Size(0, 39);
            this.lbl_Settings_Warning.TabIndex = 15;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lbl_Settings_Warning);
            this.Controls.Add(this.lbl_Settings_Description);
            this.Controls.Add(this.button_Settings_DeleteUser);
            this.Controls.Add(this.textBox_Settings_UserID);
            this.Controls.Add(this.lbl_Settings_UserIDTitle);
            this.Controls.Add(this.button_Settings_AddUser);
            this.Controls.Add(this.textBox_Settings_Password);
            this.Controls.Add(this.textBox_Settings_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Settings_UserNameTitle);
            this.Controls.Add(this.dataGridView_Settings_UsersList);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmSettings";
            this.Text = "FinancialCRM - Ayarlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Settings_UsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Settings_SettingsTitle;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Dashboard;
        private System.Windows.Forms.Button button_BankProcess;
        private System.Windows.Forms.Button button_Spendings;
        private System.Windows.Forms.Button button_Bills;
        private System.Windows.Forms.Button button_banks;
        private System.Windows.Forms.Button button_Categories;
        private System.Windows.Forms.DataGridView dataGridView_Settings_UsersList;
        private System.Windows.Forms.Label lbl_Settings_UserNameTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Settings_Username;
        private System.Windows.Forms.TextBox textBox_Settings_Password;
        private System.Windows.Forms.Button button_Settings_AddUser;
        private System.Windows.Forms.TextBox textBox_Settings_UserID;
        private System.Windows.Forms.Label lbl_Settings_UserIDTitle;
        private System.Windows.Forms.Button button_Settings_DeleteUser;
        private System.Windows.Forms.Label lbl_Settings_Description;
        private System.Windows.Forms.Label lbl_Settings_Warning;
    }
}
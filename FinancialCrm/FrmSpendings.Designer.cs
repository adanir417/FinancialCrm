namespace FinancialCrm
{
    partial class FrmSpendings
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
            this.components = new System.ComponentModel.Container();
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
            this.panel_ThisMonthSpending = new System.Windows.Forms.Panel();
            this.lbl_TotalSpendingInThisMonth = new System.Windows.Forms.Label();
            this.lbl_ThisMonthSpendingTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TotalSpendingT = new System.Windows.Forms.Label();
            this.lbl_TotalSpending = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_MostSpendingCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer_Statistics = new System.Windows.Forms.Timer(this.components);
            this.dataGridView_Spendings = new System.Windows.Forms.DataGridView();
            this.button_Spendings_AddSpendings = new System.Windows.Forms.Button();
            this.button_Spendings_UpdateSpendings = new System.Windows.Forms.Button();
            this.button_Spending_ListSpendings = new System.Windows.Forms.Button();
            this.button_Spendings_DeleteSpendings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Spendings_SpendingID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Spendings_SpendingTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Spendings_SpendingAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Spendings_Categories = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Spendings_SpendingDate = new System.Windows.Forms.DateTimePicker();
            this.panel_Title.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            this.panel_ThisMonthSpending.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spendings)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Settings_SettingsTitle
            // 
            this.lbl_Settings_SettingsTitle.AutoSize = true;
            this.lbl_Settings_SettingsTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings_SettingsTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Settings_SettingsTitle.Location = new System.Drawing.Point(14, 7);
            this.lbl_Settings_SettingsTitle.Name = "lbl_Settings_SettingsTitle";
            this.lbl_Settings_SettingsTitle.Size = new System.Drawing.Size(124, 39);
            this.lbl_Settings_SettingsTitle.TabIndex = 0;
            this.lbl_Settings_SettingsTitle.Text = "Giderler";
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.DarkBlue;
            this.panel_Title.Controls.Add(this.lbl_Settings_SettingsTitle);
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(2000, 49);
            this.panel_Title.TabIndex = 4;
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
            this.panel_Buttons.TabIndex = 5;
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
            // panel_ThisMonthSpending
            // 
            this.panel_ThisMonthSpending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.panel_ThisMonthSpending.Controls.Add(this.lbl_TotalSpendingInThisMonth);
            this.panel_ThisMonthSpending.Controls.Add(this.lbl_ThisMonthSpendingTitle);
            this.panel_ThisMonthSpending.Location = new System.Drawing.Point(246, 55);
            this.panel_ThisMonthSpending.Name = "panel_ThisMonthSpending";
            this.panel_ThisMonthSpending.Size = new System.Drawing.Size(265, 141);
            this.panel_ThisMonthSpending.TabIndex = 6;
            // 
            // lbl_TotalSpendingInThisMonth
            // 
            this.lbl_TotalSpendingInThisMonth.AutoSize = true;
            this.lbl_TotalSpendingInThisMonth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalSpendingInThisMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TotalSpendingInThisMonth.Location = new System.Drawing.Point(20, 75);
            this.lbl_TotalSpendingInThisMonth.Name = "lbl_TotalSpendingInThisMonth";
            this.lbl_TotalSpendingInThisMonth.Size = new System.Drawing.Size(49, 19);
            this.lbl_TotalSpendingInThisMonth.TabIndex = 1;
            this.lbl_TotalSpendingInThisMonth.Text = "0.00 ₺";
            // 
            // lbl_ThisMonthSpendingTitle
            // 
            this.lbl_ThisMonthSpendingTitle.AutoSize = true;
            this.lbl_ThisMonthSpendingTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThisMonthSpendingTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ThisMonthSpendingTitle.Location = new System.Drawing.Point(18, 16);
            this.lbl_ThisMonthSpendingTitle.Name = "lbl_ThisMonthSpendingTitle";
            this.lbl_ThisMonthSpendingTitle.Size = new System.Drawing.Size(224, 26);
            this.lbl_ThisMonthSpendingTitle.TabIndex = 0;
            this.lbl_ThisMonthSpendingTitle.Text = "Bu Ayki Toplam Harcama";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.lbl_TotalSpendingT);
            this.panel1.Controls.Add(this.lbl_TotalSpending);
            this.panel1.Location = new System.Drawing.Point(576, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 141);
            this.panel1.TabIndex = 7;
            // 
            // lbl_TotalSpendingT
            // 
            this.lbl_TotalSpendingT.AutoSize = true;
            this.lbl_TotalSpendingT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalSpendingT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TotalSpendingT.Location = new System.Drawing.Point(20, 75);
            this.lbl_TotalSpendingT.Name = "lbl_TotalSpendingT";
            this.lbl_TotalSpendingT.Size = new System.Drawing.Size(49, 19);
            this.lbl_TotalSpendingT.TabIndex = 1;
            this.lbl_TotalSpendingT.Text = "0.00 ₺";
            // 
            // lbl_TotalSpending
            // 
            this.lbl_TotalSpending.AutoSize = true;
            this.lbl_TotalSpending.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalSpending.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TotalSpending.Location = new System.Drawing.Point(18, 16);
            this.lbl_TotalSpending.Name = "lbl_TotalSpending";
            this.lbl_TotalSpending.Size = new System.Drawing.Size(155, 26);
            this.lbl_TotalSpending.TabIndex = 0;
            this.lbl_TotalSpending.Text = "Toplam Harcama";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.lbl_MostSpendingCategory);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(906, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 141);
            this.panel2.TabIndex = 7;
            // 
            // lbl_MostSpendingCategory
            // 
            this.lbl_MostSpendingCategory.AutoSize = true;
            this.lbl_MostSpendingCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MostSpendingCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_MostSpendingCategory.Location = new System.Drawing.Point(20, 75);
            this.lbl_MostSpendingCategory.Name = "lbl_MostSpendingCategory";
            this.lbl_MostSpendingCategory.Size = new System.Drawing.Size(0, 19);
            this.lbl_MostSpendingCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 52);
            this.label4.TabIndex = 0;
            this.label4.Text = "En Çok Harcama Yapılan \r\nKategori";
            // 
            // timer_Statistics
            // 
            this.timer_Statistics.Enabled = true;
            this.timer_Statistics.Interval = 1000;
            this.timer_Statistics.Tick += new System.EventHandler(this.timer_Statistics_Tick);
            // 
            // dataGridView_Spendings
            // 
            this.dataGridView_Spendings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Spendings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Spendings.Location = new System.Drawing.Point(576, 207);
            this.dataGridView_Spendings.Name = "dataGridView_Spendings";
            this.dataGridView_Spendings.Size = new System.Drawing.Size(596, 542);
            this.dataGridView_Spendings.TabIndex = 8;
            // 
            // button_Spendings_AddSpendings
            // 
            this.button_Spendings_AddSpendings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(58)))));
            this.button_Spendings_AddSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Spendings_AddSpendings.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Spendings_AddSpendings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Spendings_AddSpendings.Location = new System.Drawing.Point(232, 641);
            this.button_Spendings_AddSpendings.Name = "button_Spendings_AddSpendings";
            this.button_Spendings_AddSpendings.Size = new System.Drawing.Size(338, 32);
            this.button_Spendings_AddSpendings.TabIndex = 9;
            this.button_Spendings_AddSpendings.Text = "Gider Ekle";
            this.button_Spendings_AddSpendings.UseVisualStyleBackColor = false;
            this.button_Spendings_AddSpendings.Click += new System.EventHandler(this.button_Spendings_AddSpendings_Click);
            // 
            // button_Spendings_UpdateSpendings
            // 
            this.button_Spendings_UpdateSpendings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(58)))));
            this.button_Spendings_UpdateSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Spendings_UpdateSpendings.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Spendings_UpdateSpendings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Spendings_UpdateSpendings.Location = new System.Drawing.Point(232, 679);
            this.button_Spendings_UpdateSpendings.Name = "button_Spendings_UpdateSpendings";
            this.button_Spendings_UpdateSpendings.Size = new System.Drawing.Size(338, 32);
            this.button_Spendings_UpdateSpendings.TabIndex = 10;
            this.button_Spendings_UpdateSpendings.Text = "Gider Güncelle";
            this.button_Spendings_UpdateSpendings.UseVisualStyleBackColor = false;
            this.button_Spendings_UpdateSpendings.Click += new System.EventHandler(this.button_Spendings_UpdateSpendings_Click);
            // 
            // button_Spending_ListSpendings
            // 
            this.button_Spending_ListSpendings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(58)))));
            this.button_Spending_ListSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Spending_ListSpendings.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Spending_ListSpendings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Spending_ListSpendings.Location = new System.Drawing.Point(232, 603);
            this.button_Spending_ListSpendings.Name = "button_Spending_ListSpendings";
            this.button_Spending_ListSpendings.Size = new System.Drawing.Size(338, 32);
            this.button_Spending_ListSpendings.TabIndex = 11;
            this.button_Spending_ListSpendings.Text = "Gider Listele";
            this.button_Spending_ListSpendings.UseVisualStyleBackColor = false;
            this.button_Spending_ListSpendings.Click += new System.EventHandler(this.button_Spending_ListSpendings_Click);
            // 
            // button_Spendings_DeleteSpendings
            // 
            this.button_Spendings_DeleteSpendings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(47)))), ((int)(((byte)(6)))));
            this.button_Spendings_DeleteSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Spendings_DeleteSpendings.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Spendings_DeleteSpendings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Spendings_DeleteSpendings.Location = new System.Drawing.Point(232, 717);
            this.button_Spendings_DeleteSpendings.Name = "button_Spendings_DeleteSpendings";
            this.button_Spendings_DeleteSpendings.Size = new System.Drawing.Size(338, 32);
            this.button_Spendings_DeleteSpendings.TabIndex = 12;
            this.button_Spendings_DeleteSpendings.Text = "Gider Sil";
            this.button_Spendings_DeleteSpendings.UseVisualStyleBackColor = false;
            this.button_Spendings_DeleteSpendings.Click += new System.EventHandler(this.button_Spendings_DeleteSpendings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(244, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "GiderID: ";
            // 
            // textBox_Spendings_SpendingID
            // 
            this.textBox_Spendings_SpendingID.Location = new System.Drawing.Point(246, 235);
            this.textBox_Spendings_SpendingID.Name = "textBox_Spendings_SpendingID";
            this.textBox_Spendings_SpendingID.Size = new System.Drawing.Size(265, 20);
            this.textBox_Spendings_SpendingID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(244, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gider Başlığı: ";
            // 
            // textBox_Spendings_SpendingTitle
            // 
            this.textBox_Spendings_SpendingTitle.Location = new System.Drawing.Point(246, 296);
            this.textBox_Spendings_SpendingTitle.Name = "textBox_Spendings_SpendingTitle";
            this.textBox_Spendings_SpendingTitle.Size = new System.Drawing.Size(265, 20);
            this.textBox_Spendings_SpendingTitle.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(244, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gider Tarihi: ";
            // 
            // textBox_Spendings_SpendingAmount
            // 
            this.textBox_Spendings_SpendingAmount.Location = new System.Drawing.Point(246, 357);
            this.textBox_Spendings_SpendingAmount.Name = "textBox_Spendings_SpendingAmount";
            this.textBox_Spendings_SpendingAmount.Size = new System.Drawing.Size(265, 20);
            this.textBox_Spendings_SpendingAmount.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(244, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Harcama Tutarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(244, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kategori: ";
            // 
            // comboBox_Spendings_Categories
            // 
            this.comboBox_Spendings_Categories.FormattingEnabled = true;
            this.comboBox_Spendings_Categories.Location = new System.Drawing.Point(246, 479);
            this.comboBox_Spendings_Categories.Name = "comboBox_Spendings_Categories";
            this.comboBox_Spendings_Categories.Size = new System.Drawing.Size(265, 21);
            this.comboBox_Spendings_Categories.TabIndex = 22;
            // 
            // dateTimePicker_Spendings_SpendingDate
            // 
            this.dateTimePicker_Spendings_SpendingDate.Location = new System.Drawing.Point(246, 418);
            this.dateTimePicker_Spendings_SpendingDate.Name = "dateTimePicker_Spendings_SpendingDate";
            this.dateTimePicker_Spendings_SpendingDate.Size = new System.Drawing.Size(265, 20);
            this.dateTimePicker_Spendings_SpendingDate.TabIndex = 23;
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.dateTimePicker_Spendings_SpendingDate);
            this.Controls.Add(this.comboBox_Spendings_Categories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Spendings_SpendingAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Spendings_SpendingTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Spendings_SpendingID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Spendings_DeleteSpendings);
            this.Controls.Add(this.button_Spending_ListSpendings);
            this.Controls.Add(this.button_Spendings_UpdateSpendings);
            this.Controls.Add(this.button_Spendings_AddSpendings);
            this.Controls.Add(this.dataGridView_Spendings);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ThisMonthSpending);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmSpendings";
            this.Text = "FinancialCRM - Giderler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSpendings_FormClosing);
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            this.panel_ThisMonthSpending.ResumeLayout(false);
            this.panel_ThisMonthSpending.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Spendings)).EndInit();
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
        private System.Windows.Forms.Panel panel_ThisMonthSpending;
        private System.Windows.Forms.Label lbl_ThisMonthSpendingTitle;
        private System.Windows.Forms.Label lbl_TotalSpendingInThisMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TotalSpendingT;
        private System.Windows.Forms.Label lbl_TotalSpending;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_MostSpendingCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer_Statistics;
        private System.Windows.Forms.DataGridView dataGridView_Spendings;
        private System.Windows.Forms.Button button_Spendings_AddSpendings;
        private System.Windows.Forms.Button button_Spendings_UpdateSpendings;
        private System.Windows.Forms.Button button_Spending_ListSpendings;
        private System.Windows.Forms.Button button_Spendings_DeleteSpendings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Spendings_SpendingID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Spendings_SpendingTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Spendings_SpendingAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Spendings_Categories;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Spendings_SpendingDate;
    }
}
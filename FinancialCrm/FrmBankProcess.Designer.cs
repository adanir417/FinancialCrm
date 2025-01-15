namespace FinancialCrm
{
    partial class FrmBankProcess
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
            this.panel_Title = new System.Windows.Forms.Panel();
            this.lbl_BankProcessTitle = new System.Windows.Forms.Label();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Dashboard = new System.Windows.Forms.Button();
            this.button_BankProcess = new System.Windows.Forms.Button();
            this.button_Spendings = new System.Windows.Forms.Button();
            this.button_Bills = new System.Windows.Forms.Button();
            this.button_banks = new System.Windows.Forms.Button();
            this.button_Categories = new System.Windows.Forms.Button();
            this.lbl_Categories_CategoryNameTitle = new System.Windows.Forms.Label();
            this.textBox_BankProcess_BankProcessID = new System.Windows.Forms.TextBox();
            this.lbl_Categories_CategoryIDTitle = new System.Windows.Forms.Label();
            this.dataGridView_CategoryList = new System.Windows.Forms.DataGridView();
            this.button_Categories_ListCategory = new System.Windows.Forms.Button();
            this.button_BankProcess_DeleteBankProcess = new System.Windows.Forms.Button();
            this.button_Categories_UpdateCategory = new System.Windows.Forms.Button();
            this.button_Categories_AddCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_BankProcess_Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_BankProcess_ProcessType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_BankProcess_Description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_BankProcess_Banks = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_BankProcess_ProcessDate = new System.Windows.Forms.DateTimePicker();
            this.panel_Title.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.DarkBlue;
            this.panel_Title.Controls.Add(this.lbl_BankProcessTitle);
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(2000, 49);
            this.panel_Title.TabIndex = 2;
            // 
            // lbl_BankProcessTitle
            // 
            this.lbl_BankProcessTitle.AutoSize = true;
            this.lbl_BankProcessTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BankProcessTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BankProcessTitle.Location = new System.Drawing.Point(14, 7);
            this.lbl_BankProcessTitle.Name = "lbl_BankProcessTitle";
            this.lbl_BankProcessTitle.Size = new System.Drawing.Size(253, 39);
            this.lbl_BankProcessTitle.TabIndex = 0;
            this.lbl_BankProcessTitle.Text = "Banka Hareketleri";
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
            this.panel_Buttons.TabIndex = 3;
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
            // lbl_Categories_CategoryNameTitle
            // 
            this.lbl_Categories_CategoryNameTitle.AutoSize = true;
            this.lbl_Categories_CategoryNameTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categories_CategoryNameTitle.Location = new System.Drawing.Point(232, 113);
            this.lbl_Categories_CategoryNameTitle.Name = "lbl_Categories_CategoryNameTitle";
            this.lbl_Categories_CategoryNameTitle.Size = new System.Drawing.Size(91, 19);
            this.lbl_Categories_CategoryNameTitle.TabIndex = 21;
            this.lbl_Categories_CategoryNameTitle.Text = "İşlem Tarihi: ";
            // 
            // textBox_BankProcess_BankProcessID
            // 
            this.textBox_BankProcess_BankProcessID.Location = new System.Drawing.Point(375, 77);
            this.textBox_BankProcess_BankProcessID.Name = "textBox_BankProcess_BankProcessID";
            this.textBox_BankProcess_BankProcessID.Size = new System.Drawing.Size(88, 20);
            this.textBox_BankProcess_BankProcessID.TabIndex = 20;
            // 
            // lbl_Categories_CategoryIDTitle
            // 
            this.lbl_Categories_CategoryIDTitle.AutoSize = true;
            this.lbl_Categories_CategoryIDTitle.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categories_CategoryIDTitle.Location = new System.Drawing.Point(228, 75);
            this.lbl_Categories_CategoryIDTitle.Name = "lbl_Categories_CategoryIDTitle";
            this.lbl_Categories_CategoryIDTitle.Size = new System.Drawing.Size(140, 21);
            this.lbl_Categories_CategoryIDTitle.TabIndex = 19;
            this.lbl_Categories_CategoryIDTitle.Text = "Banka Hareketi ID: ";
            // 
            // dataGridView_CategoryList
            // 
            this.dataGridView_CategoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CategoryList.Location = new System.Drawing.Point(476, 158);
            this.dataGridView_CategoryList.Name = "dataGridView_CategoryList";
            this.dataGridView_CategoryList.Size = new System.Drawing.Size(696, 588);
            this.dataGridView_CategoryList.TabIndex = 18;
            // 
            // button_Categories_ListCategory
            // 
            this.button_Categories_ListCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Categories_ListCategory.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button_Categories_ListCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Categories_ListCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Categories_ListCategory.Location = new System.Drawing.Point(264, 163);
            this.button_Categories_ListCategory.Name = "button_Categories_ListCategory";
            this.button_Categories_ListCategory.Size = new System.Drawing.Size(171, 65);
            this.button_Categories_ListCategory.TabIndex = 17;
            this.button_Categories_ListCategory.Text = "Banka Hareketleri\r\n Listele";
            this.button_Categories_ListCategory.UseVisualStyleBackColor = false;
            this.button_Categories_ListCategory.Click += new System.EventHandler(this.button_Categories_ListCategory_Click);
            // 
            // button_BankProcess_DeleteBankProcess
            // 
            this.button_BankProcess_DeleteBankProcess.BackColor = System.Drawing.Color.Red;
            this.button_BankProcess_DeleteBankProcess.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button_BankProcess_DeleteBankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BankProcess_DeleteBankProcess.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BankProcess_DeleteBankProcess.Location = new System.Drawing.Point(264, 393);
            this.button_BankProcess_DeleteBankProcess.Name = "button_BankProcess_DeleteBankProcess";
            this.button_BankProcess_DeleteBankProcess.Size = new System.Drawing.Size(171, 47);
            this.button_BankProcess_DeleteBankProcess.TabIndex = 16;
            this.button_BankProcess_DeleteBankProcess.Text = "Banka Hareketi Sil";
            this.button_BankProcess_DeleteBankProcess.UseVisualStyleBackColor = false;
            this.button_BankProcess_DeleteBankProcess.Click += new System.EventHandler(this.button_BankProcess_DeleteBankProcess_Click);
            // 
            // button_Categories_UpdateCategory
            // 
            this.button_Categories_UpdateCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Categories_UpdateCategory.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button_Categories_UpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Categories_UpdateCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Categories_UpdateCategory.Location = new System.Drawing.Point(264, 313);
            this.button_Categories_UpdateCategory.Name = "button_Categories_UpdateCategory";
            this.button_Categories_UpdateCategory.Size = new System.Drawing.Size(171, 61);
            this.button_Categories_UpdateCategory.TabIndex = 15;
            this.button_Categories_UpdateCategory.Text = "Banka Hareketi \r\nGüncelle";
            this.button_Categories_UpdateCategory.UseVisualStyleBackColor = false;
            this.button_Categories_UpdateCategory.Click += new System.EventHandler(this.button_Categories_UpdateCategory_Click);
            // 
            // button_Categories_AddCategory
            // 
            this.button_Categories_AddCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Categories_AddCategory.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button_Categories_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Categories_AddCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Categories_AddCategory.Location = new System.Drawing.Point(264, 247);
            this.button_Categories_AddCategory.Name = "button_Categories_AddCategory";
            this.button_Categories_AddCategory.Size = new System.Drawing.Size(171, 47);
            this.button_Categories_AddCategory.TabIndex = 14;
            this.button_Categories_AddCategory.Text = "Banka Hareketi Ekle";
            this.button_Categories_AddCategory.UseVisualStyleBackColor = false;
            this.button_Categories_AddCategory.Click += new System.EventHandler(this.button_Categories_AddCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(751, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Banka : ";
            // 
            // textBox_BankProcess_Amount
            // 
            this.textBox_BankProcess_Amount.Location = new System.Drawing.Point(565, 112);
            this.textBox_BankProcess_Amount.Name = "textBox_BankProcess_Amount";
            this.textBox_BankProcess_Amount.Size = new System.Drawing.Size(180, 20);
            this.textBox_BankProcess_Amount.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "İşlem Tutarı: ";
            // 
            // textBox_BankProcess_ProcessType
            // 
            this.textBox_BankProcess_ProcessType.Location = new System.Drawing.Point(1048, 109);
            this.textBox_BankProcess_ProcessType.Name = "textBox_BankProcess_ProcessType";
            this.textBox_BankProcess_ProcessType.Size = new System.Drawing.Size(124, 20);
            this.textBox_BankProcess_ProcessType.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(963, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "İşlem Tipi: ";
            // 
            // textBox_BankProcess_Description
            // 
            this.textBox_BankProcess_Description.Location = new System.Drawing.Point(667, 76);
            this.textBox_BankProcess_Description.Name = "textBox_BankProcess_Description";
            this.textBox_BankProcess_Description.Size = new System.Drawing.Size(484, 20);
            this.textBox_BankProcess_Description.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Banka Hareketi Açıklama: ";
            // 
            // comboBox_BankProcess_Banks
            // 
            this.comboBox_BankProcess_Banks.FormattingEnabled = true;
            this.comboBox_BankProcess_Banks.Location = new System.Drawing.Point(813, 109);
            this.comboBox_BankProcess_Banks.Name = "comboBox_BankProcess_Banks";
            this.comboBox_BankProcess_Banks.Size = new System.Drawing.Size(146, 21);
            this.comboBox_BankProcess_Banks.TabIndex = 31;
            // 
            // dateTimePicker_BankProcess_ProcessDate
            // 
            this.dateTimePicker_BankProcess_ProcessDate.Location = new System.Drawing.Point(329, 113);
            this.dateTimePicker_BankProcess_ProcessDate.Name = "dateTimePicker_BankProcess_ProcessDate";
            this.dateTimePicker_BankProcess_ProcessDate.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker_BankProcess_ProcessDate.TabIndex = 32;
            // 
            // FrmBankProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.dateTimePicker_BankProcess_ProcessDate);
            this.Controls.Add(this.comboBox_BankProcess_Banks);
            this.Controls.Add(this.textBox_BankProcess_ProcessType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_BankProcess_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_BankProcess_Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Categories_CategoryNameTitle);
            this.Controls.Add(this.textBox_BankProcess_BankProcessID);
            this.Controls.Add(this.lbl_Categories_CategoryIDTitle);
            this.Controls.Add(this.dataGridView_CategoryList);
            this.Controls.Add(this.button_Categories_ListCategory);
            this.Controls.Add(this.button_BankProcess_DeleteBankProcess);
            this.Controls.Add(this.button_Categories_UpdateCategory);
            this.Controls.Add(this.button_Categories_AddCategory);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmBankProcess";
            this.Text = "FinancialCRM - Banka Hareketleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBankProcess_FormClosing);
            this.Load += new System.EventHandler(this.FrmBankProcess_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label lbl_BankProcessTitle;
        private System.Windows.Forms.Panel panel_Buttons;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Dashboard;
        private System.Windows.Forms.Button button_BankProcess;
        private System.Windows.Forms.Button button_Spendings;
        private System.Windows.Forms.Button button_Bills;
        private System.Windows.Forms.Button button_banks;
        private System.Windows.Forms.Button button_Categories;
        private System.Windows.Forms.Label lbl_Categories_CategoryNameTitle;
        private System.Windows.Forms.TextBox textBox_BankProcess_BankProcessID;
        private System.Windows.Forms.Label lbl_Categories_CategoryIDTitle;
        private System.Windows.Forms.DataGridView dataGridView_CategoryList;
        private System.Windows.Forms.Button button_Categories_ListCategory;
        private System.Windows.Forms.Button button_BankProcess_DeleteBankProcess;
        private System.Windows.Forms.Button button_Categories_UpdateCategory;
        private System.Windows.Forms.Button button_Categories_AddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_BankProcess_Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_BankProcess_ProcessType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_BankProcess_Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_BankProcess_Banks;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BankProcess_ProcessDate;
    }
}
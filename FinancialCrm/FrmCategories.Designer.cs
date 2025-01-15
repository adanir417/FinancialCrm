namespace FinancialCrm
{
    partial class FrmCategories
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
            this.lbl_Dashboard_DashboardTitle = new System.Windows.Forms.Label();
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
            this.button_Categories_AddCategory = new System.Windows.Forms.Button();
            this.button_Categories_UpdateCategory = new System.Windows.Forms.Button();
            this.button_Categories_DeleteCategory = new System.Windows.Forms.Button();
            this.button_Categories_ListCategory = new System.Windows.Forms.Button();
            this.dataGridView_CategoryList = new System.Windows.Forms.DataGridView();
            this.lbl_Categories_CategoryIDTitle = new System.Windows.Forms.Label();
            this.textBox_Categories_CategoryID = new System.Windows.Forms.TextBox();
            this.textBox_Categories_CategoryName = new System.Windows.Forms.TextBox();
            this.lbl_Categories_CategoryNameTitle = new System.Windows.Forms.Label();
            this.panel_Title.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Dashboard_DashboardTitle
            // 
            this.lbl_Dashboard_DashboardTitle.AutoSize = true;
            this.lbl_Dashboard_DashboardTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dashboard_DashboardTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Dashboard_DashboardTitle.Location = new System.Drawing.Point(14, 7);
            this.lbl_Dashboard_DashboardTitle.Name = "lbl_Dashboard_DashboardTitle";
            this.lbl_Dashboard_DashboardTitle.Size = new System.Drawing.Size(164, 39);
            this.lbl_Dashboard_DashboardTitle.TabIndex = 0;
            this.lbl_Dashboard_DashboardTitle.Text = "Kategoriler";
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.DarkBlue;
            this.panel_Title.Controls.Add(this.lbl_Dashboard_DashboardTitle);
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
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
            // button_Categories_AddCategory
            // 
            this.button_Categories_AddCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Categories_AddCategory.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button_Categories_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Categories_AddCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Categories_AddCategory.Location = new System.Drawing.Point(521, 184);
            this.button_Categories_AddCategory.Name = "button_Categories_AddCategory";
            this.button_Categories_AddCategory.Size = new System.Drawing.Size(171, 47);
            this.button_Categories_AddCategory.TabIndex = 5;
            this.button_Categories_AddCategory.Text = "Kategori Ekle";
            this.button_Categories_AddCategory.UseVisualStyleBackColor = false;
            this.button_Categories_AddCategory.Click += new System.EventHandler(this.button_Categories_AddCategory_Click);
            // 
            // button_Categories_UpdateCategory
            // 
            this.button_Categories_UpdateCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Categories_UpdateCategory.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button_Categories_UpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Categories_UpdateCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Categories_UpdateCategory.Location = new System.Drawing.Point(521, 257);
            this.button_Categories_UpdateCategory.Name = "button_Categories_UpdateCategory";
            this.button_Categories_UpdateCategory.Size = new System.Drawing.Size(171, 47);
            this.button_Categories_UpdateCategory.TabIndex = 6;
            this.button_Categories_UpdateCategory.Text = "Kategori Güncelle";
            this.button_Categories_UpdateCategory.UseVisualStyleBackColor = false;
            this.button_Categories_UpdateCategory.Click += new System.EventHandler(this.button_Categories_UpdateCategory_Click);
            // 
            // button_Categories_DeleteCategory
            // 
            this.button_Categories_DeleteCategory.BackColor = System.Drawing.Color.Red;
            this.button_Categories_DeleteCategory.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button_Categories_DeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Categories_DeleteCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Categories_DeleteCategory.Location = new System.Drawing.Point(304, 257);
            this.button_Categories_DeleteCategory.Name = "button_Categories_DeleteCategory";
            this.button_Categories_DeleteCategory.Size = new System.Drawing.Size(171, 47);
            this.button_Categories_DeleteCategory.TabIndex = 7;
            this.button_Categories_DeleteCategory.Text = "Kategori Sil";
            this.button_Categories_DeleteCategory.UseVisualStyleBackColor = false;
            this.button_Categories_DeleteCategory.Click += new System.EventHandler(this.button_Categories_DeleteCategory_Click);
            // 
            // button_Categories_ListCategory
            // 
            this.button_Categories_ListCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Categories_ListCategory.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button_Categories_ListCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Categories_ListCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Categories_ListCategory.Location = new System.Drawing.Point(304, 184);
            this.button_Categories_ListCategory.Name = "button_Categories_ListCategory";
            this.button_Categories_ListCategory.Size = new System.Drawing.Size(171, 47);
            this.button_Categories_ListCategory.TabIndex = 8;
            this.button_Categories_ListCategory.Text = "Kategorileri Listele";
            this.button_Categories_ListCategory.UseVisualStyleBackColor = false;
            this.button_Categories_ListCategory.Click += new System.EventHandler(this.button_Categories_ListCategory_Click);
            // 
            // dataGridView_CategoryList
            // 
            this.dataGridView_CategoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CategoryList.Location = new System.Drawing.Point(852, 55);
            this.dataGridView_CategoryList.Name = "dataGridView_CategoryList";
            this.dataGridView_CategoryList.Size = new System.Drawing.Size(320, 694);
            this.dataGridView_CategoryList.TabIndex = 9;
            // 
            // lbl_Categories_CategoryIDTitle
            // 
            this.lbl_Categories_CategoryIDTitle.AutoSize = true;
            this.lbl_Categories_CategoryIDTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categories_CategoryIDTitle.Location = new System.Drawing.Point(273, 78);
            this.lbl_Categories_CategoryIDTitle.Name = "lbl_Categories_CategoryIDTitle";
            this.lbl_Categories_CategoryIDTitle.Size = new System.Drawing.Size(117, 26);
            this.lbl_Categories_CategoryIDTitle.TabIndex = 10;
            this.lbl_Categories_CategoryIDTitle.Text = "Kategori ID: ";
            // 
            // textBox_Categories_CategoryID
            // 
            this.textBox_Categories_CategoryID.Location = new System.Drawing.Point(431, 83);
            this.textBox_Categories_CategoryID.Name = "textBox_Categories_CategoryID";
            this.textBox_Categories_CategoryID.Size = new System.Drawing.Size(261, 20);
            this.textBox_Categories_CategoryID.TabIndex = 11;
            // 
            // textBox_Categories_CategoryName
            // 
            this.textBox_Categories_CategoryName.Location = new System.Drawing.Point(431, 122);
            this.textBox_Categories_CategoryName.Name = "textBox_Categories_CategoryName";
            this.textBox_Categories_CategoryName.Size = new System.Drawing.Size(261, 20);
            this.textBox_Categories_CategoryName.TabIndex = 13;
            // 
            // lbl_Categories_CategoryNameTitle
            // 
            this.lbl_Categories_CategoryNameTitle.AutoSize = true;
            this.lbl_Categories_CategoryNameTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categories_CategoryNameTitle.Location = new System.Drawing.Point(263, 117);
            this.lbl_Categories_CategoryNameTitle.Name = "lbl_Categories_CategoryNameTitle";
            this.lbl_Categories_CategoryNameTitle.Size = new System.Drawing.Size(127, 26);
            this.lbl_Categories_CategoryNameTitle.TabIndex = 12;
            this.lbl_Categories_CategoryNameTitle.Text = "Kategori Adı: ";
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.textBox_Categories_CategoryName);
            this.Controls.Add(this.lbl_Categories_CategoryNameTitle);
            this.Controls.Add(this.textBox_Categories_CategoryID);
            this.Controls.Add(this.lbl_Categories_CategoryIDTitle);
            this.Controls.Add(this.dataGridView_CategoryList);
            this.Controls.Add(this.button_Categories_ListCategory);
            this.Controls.Add(this.button_Categories_DeleteCategory);
            this.Controls.Add(this.button_Categories_UpdateCategory);
            this.Controls.Add(this.button_Categories_AddCategory);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCategories";
            this.Text = "FinancialCRM - Kategoriler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCategories_FormClosing);
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dashboard_DashboardTitle;
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
        private System.Windows.Forms.Button button_Categories_AddCategory;
        private System.Windows.Forms.Button button_Categories_UpdateCategory;
        private System.Windows.Forms.Button button_Categories_DeleteCategory;
        private System.Windows.Forms.Button button_Categories_ListCategory;
        private System.Windows.Forms.DataGridView dataGridView_CategoryList;
        private System.Windows.Forms.Label lbl_Categories_CategoryIDTitle;
        private System.Windows.Forms.TextBox textBox_Categories_CategoryID;
        private System.Windows.Forms.TextBox textBox_Categories_CategoryName;
        private System.Windows.Forms.Label lbl_Categories_CategoryNameTitle;
    }
}
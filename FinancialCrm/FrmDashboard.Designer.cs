namespace FinancialCrm
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_LastMoneyTrasferT = new System.Windows.Forms.Label();
            this.lbl_LastMoneyTransfer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_BillAmount = new System.Windows.Forms.Label();
            this.lbl_BillTitle = new System.Windows.Forms.Label();
            this.panel_ThisMonthSpending = new System.Windows.Forms.Panel();
            this.lbl_TotalBalanceT = new System.Windows.Forms.Label();
            this.lbl_TotalBalanceTitle = new System.Windows.Forms.Label();
            this.timer_Dashboard = new System.Windows.Forms.Timer(this.components);
            this.chart_Left = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Right = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_Title.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_ThisMonthSpending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Right)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Dashboard_DashboardTitle
            // 
            this.lbl_Dashboard_DashboardTitle.AutoSize = true;
            this.lbl_Dashboard_DashboardTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dashboard_DashboardTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Dashboard_DashboardTitle.Location = new System.Drawing.Point(14, 7);
            this.lbl_Dashboard_DashboardTitle.Name = "lbl_Dashboard_DashboardTitle";
            this.lbl_Dashboard_DashboardTitle.Size = new System.Drawing.Size(436, 39);
            this.lbl_Dashboard_DashboardTitle.TabIndex = 0;
            this.lbl_Dashboard_DashboardTitle.Text = "Dashboard / Genel Bakış Formu";
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.DarkBlue;
            this.panel_Title.Controls.Add(this.lbl_Dashboard_DashboardTitle);
            this.panel_Title.Location = new System.Drawing.Point(-2, 1);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(2000, 49);
            this.panel_Title.TabIndex = 2;
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
            this.panel_Buttons.Location = new System.Drawing.Point(-2, 49);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(224)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.lbl_LastMoneyTrasferT);
            this.panel2.Controls.Add(this.lbl_LastMoneyTransfer);
            this.panel2.Location = new System.Drawing.Point(902, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 141);
            this.panel2.TabIndex = 10;
            // 
            // lbl_LastMoneyTrasferT
            // 
            this.lbl_LastMoneyTrasferT.AutoSize = true;
            this.lbl_LastMoneyTrasferT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastMoneyTrasferT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_LastMoneyTrasferT.Location = new System.Drawing.Point(20, 75);
            this.lbl_LastMoneyTrasferT.Name = "lbl_LastMoneyTrasferT";
            this.lbl_LastMoneyTrasferT.Size = new System.Drawing.Size(49, 19);
            this.lbl_LastMoneyTrasferT.TabIndex = 1;
            this.lbl_LastMoneyTrasferT.Text = "0.00 ₺";
            // 
            // lbl_LastMoneyTransfer
            // 
            this.lbl_LastMoneyTransfer.AutoSize = true;
            this.lbl_LastMoneyTransfer.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastMoneyTransfer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_LastMoneyTransfer.Location = new System.Drawing.Point(18, 16);
            this.lbl_LastMoneyTransfer.Name = "lbl_LastMoneyTransfer";
            this.lbl_LastMoneyTransfer.Size = new System.Drawing.Size(160, 26);
            this.lbl_LastMoneyTransfer.TabIndex = 0;
            this.lbl_LastMoneyTransfer.Text = "Gelen Son Havale";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.lbl_BillAmount);
            this.panel1.Controls.Add(this.lbl_BillTitle);
            this.panel1.Location = new System.Drawing.Point(572, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 141);
            this.panel1.TabIndex = 9;
            // 
            // lbl_BillAmount
            // 
            this.lbl_BillAmount.AutoSize = true;
            this.lbl_BillAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BillAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BillAmount.Location = new System.Drawing.Point(20, 75);
            this.lbl_BillAmount.Name = "lbl_BillAmount";
            this.lbl_BillAmount.Size = new System.Drawing.Size(49, 19);
            this.lbl_BillAmount.TabIndex = 1;
            this.lbl_BillAmount.Text = "0.00 ₺";
            // 
            // lbl_BillTitle
            // 
            this.lbl_BillTitle.AutoSize = true;
            this.lbl_BillTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BillTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BillTitle.Location = new System.Drawing.Point(18, 16);
            this.lbl_BillTitle.Name = "lbl_BillTitle";
            this.lbl_BillTitle.Size = new System.Drawing.Size(125, 26);
            this.lbl_BillTitle.TabIndex = 0;
            this.lbl_BillTitle.Text = "Fatura Başlığı";
            // 
            // panel_ThisMonthSpending
            // 
            this.panel_ThisMonthSpending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.panel_ThisMonthSpending.Controls.Add(this.lbl_TotalBalanceT);
            this.panel_ThisMonthSpending.Controls.Add(this.lbl_TotalBalanceTitle);
            this.panel_ThisMonthSpending.Location = new System.Drawing.Point(242, 60);
            this.panel_ThisMonthSpending.Name = "panel_ThisMonthSpending";
            this.panel_ThisMonthSpending.Size = new System.Drawing.Size(265, 141);
            this.panel_ThisMonthSpending.TabIndex = 8;
            // 
            // lbl_TotalBalanceT
            // 
            this.lbl_TotalBalanceT.AutoSize = true;
            this.lbl_TotalBalanceT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalBalanceT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TotalBalanceT.Location = new System.Drawing.Point(20, 75);
            this.lbl_TotalBalanceT.Name = "lbl_TotalBalanceT";
            this.lbl_TotalBalanceT.Size = new System.Drawing.Size(49, 19);
            this.lbl_TotalBalanceT.TabIndex = 1;
            this.lbl_TotalBalanceT.Text = "0.00 ₺";
            // 
            // lbl_TotalBalanceTitle
            // 
            this.lbl_TotalBalanceTitle.AutoSize = true;
            this.lbl_TotalBalanceTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalBalanceTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TotalBalanceTitle.Location = new System.Drawing.Point(18, 16);
            this.lbl_TotalBalanceTitle.Name = "lbl_TotalBalanceTitle";
            this.lbl_TotalBalanceTitle.Size = new System.Drawing.Size(152, 26);
            this.lbl_TotalBalanceTitle.TabIndex = 0;
            this.lbl_TotalBalanceTitle.Text = "Toplam Bakiyem";
            // 
            // timer_Dashboard
            // 
            this.timer_Dashboard.Enabled = true;
            this.timer_Dashboard.Interval = 1300;
            this.timer_Dashboard.Tick += new System.EventHandler(this.timer_Dashboard_Tick);
            // 
            // chart_Left
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Left.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Left.Legends.Add(legend1);
            this.chart_Left.Location = new System.Drawing.Point(242, 345);
            this.chart_Left.Name = "chart_Left";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Left.Series.Add(series1);
            this.chart_Left.Size = new System.Drawing.Size(436, 404);
            this.chart_Left.TabIndex = 11;
            this.chart_Left.Text = "chart_Left";
            // 
            // chart_Right
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Right.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Right.Legends.Add(legend2);
            this.chart_Right.Location = new System.Drawing.Point(734, 345);
            this.chart_Right.Name = "chart_Right";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_Right.Series.Add(series2);
            this.chart_Right.Size = new System.Drawing.Size(436, 404);
            this.chart_Right.TabIndex = 12;
            this.chart_Right.Text = "chart2";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.chart_Right);
            this.Controls.Add(this.chart_Left);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ThisMonthSpending);
            this.Controls.Add(this.panel_Buttons);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmDashboard";
            this.Text = "FinancialCRM - Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_ThisMonthSpending.ResumeLayout(false);
            this.panel_ThisMonthSpending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Right)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_LastMoneyTrasferT;
        private System.Windows.Forms.Label lbl_LastMoneyTransfer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_BillAmount;
        private System.Windows.Forms.Label lbl_BillTitle;
        private System.Windows.Forms.Panel panel_ThisMonthSpending;
        private System.Windows.Forms.Label lbl_TotalBalanceT;
        private System.Windows.Forms.Label lbl_TotalBalanceTitle;
        private System.Windows.Forms.Timer timer_Dashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Left;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Right;
    }
}
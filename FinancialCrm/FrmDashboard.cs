using FinancialCrm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        FrmBankProcess frmBankProcess;
        FrmBanks frmBanks;
        FrmBilling frmBilling;
        FrmCategories frmCategories;       
        FrmSettings frmSettings;
        FrmSpendings frmSpendings;
        FrmLogin frmLogin;

        int count = 0;
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void initializeAllFrm() { 
            frmBankProcess = new FrmBankProcess();
            frmBanks = new FrmBanks();
            frmBilling = new FrmBilling();
            frmCategories = new FrmCategories();
            frmSettings = new FrmSettings();          
            frmSpendings = new FrmSpendings();
            frmLogin = new FrmLogin();

        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void button_Categories_Click(object sender, EventArgs e)
        {
            frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();           

        }

        private void button_banks_Click(object sender, EventArgs e)
        {
            frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();

        }

        private void button_Bills_Click(object sender, EventArgs e)
        {
            frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void button_Spendings_Click(object sender, EventArgs e)
        {
            frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void button_BankProcess_Click(object sender, EventArgs e)
        {
            frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
            this.Hide();
        }

        private void button_Dashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            ExitAll();
            System.Environment.Exit(0);
        }

        private void ExitAll() {

            if (frmBankProcess != null)
            {
                frmBankProcess.Close();
            }
            if (frmBanks != null)
            {
                frmBanks.Close();
            }
            if (frmBilling != null)
            {
                frmBilling.Close();
            }
            if (frmCategories != null)
            {
                frmCategories.Close();
            }
            if (frmSettings != null)
            {
                frmSettings.Close();
            }
            if (frmSpendings != null)
            {
                frmSpendings.Close();
            }
            if (frmLogin != null)
            {
                frmLogin.Close();
            }

        }

        private void ShowStatistics() { 
            lbl_TotalBalanceT.Text = db.Banks.Sum(x => x.BankBalance).ToString() + " ₺";
            lbl_LastMoneyTrasferT.Text = db.BankProcesses.OrderByDescending(x => x.BankProcessId).FirstOrDefault().Amount.ToString() + " ₺";
        
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            ExitAll();
            ShowStatistics();
            var fatura = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(z => z.BillAmount).FirstOrDefault();
            lbl_BillTitle.Text = "Elektrik Faturası";
            lbl_BillAmount.Text = fatura.ToString() + " ₺";


            // Chart Left
            var bankData = db.Banks.Select(x => new { 
            x.BankTitle,
            x.BankBalance
            }).ToList();

            chart_Left.Series.Clear();
            var series = chart_Left.Series.Add("Banka bakiyeleri");
            foreach (var bank in bankData) {
                series.Points.AddXY(bank.BankTitle, bank.BankBalance);
            }

            //Chart 2
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart_Right.Series.Clear();
            var series2 = chart_Right.Series.Add("Faturalar");
            series2.ChartType = SeriesChartType.StackedBar;
            series2.Color = Color.Red;
            foreach (var data in billData) {
                series2.Points.AddXY(data.BillTitle,data.BillAmount);
            }

        }

        private void FrmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitAll();
            System.Environment.Exit(0);
        }

        private void timer_Dashboard_Tick(object sender, EventArgs e)
        {
            ShowStatistics();
            count++;
            if (count % 4 == 1) {
                Debug.WriteLine($"Dashboard count%4=1 : {count}");
                var fatura = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(z => z.BillAmount).FirstOrDefault();
                lbl_BillTitle.Text = "Elektrik Faturası";
                lbl_BillAmount.Text = fatura.ToString() + " ₺";
            }

            if (count % 4 == 2)
            {
                Debug.WriteLine($"Dashboard count%4=2 : {count}");
                var fatura = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(z => z.BillAmount).FirstOrDefault();
                lbl_BillTitle.Text = "Doğalgaz Faturası";
                lbl_BillAmount.Text = fatura.ToString() + " ₺";
            }

            if (count % 4 == 3)
            {
                Debug.WriteLine($"Dashboard count%4=3 : {count}");
                var fatura = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(z => z.BillAmount).FirstOrDefault();
                lbl_BillTitle.Text = "Su Faturası";
                lbl_BillAmount.Text = fatura.ToString() + " ₺";
            }

            if (count % 4 == 0)
            {
                Debug.WriteLine($"Dashboard count%4=0 : {count}");
                var fatura = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(z => z.BillAmount).FirstOrDefault();
                lbl_BillTitle.Text = "İnternet Faturası";
                lbl_BillAmount.Text = fatura.ToString() + " ₺";
            }
        }
    }
}

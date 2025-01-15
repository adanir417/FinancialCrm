using FinancialCrm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        int stateOfFrmBill = 0;
        FrmBankProcess frmBankProcess;
        FrmBanks frmBanks;       
        FrmCategories frmCategories;
        FrmSettings frmSettings;
        FrmSpendings frmSpendings;
        FrmLogin frmLogin;
        FrmDashboard frmDashboard;


        public FrmBilling()
        {
            InitializeComponent();
        }

        private void initializeAllFrm()
        {
            frmBanks = new FrmBanks();
            frmBankProcess = new FrmBankProcess();
            frmSettings = new FrmSettings();          
            frmCategories = new FrmCategories();
            frmDashboard = new FrmDashboard();
            frmSpendings = new FrmSpendings();
            frmLogin = new FrmLogin();


        }

        private void ExitAll()
        {
            if (frmBanks != null)
            {
                frmBanks.Close();
            }
            if (frmSettings != null)
            {
                frmSettings.Close();
            }
            if (frmBankProcess != null)
            {
                frmBankProcess.Close();
            }
            if (frmCategories != null)
            {
                frmCategories.Close();
            }
            if (frmDashboard != null)
            {
                frmDashboard.Close();
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





        private void button_Bill_Categories_Click(object sender, EventArgs e)
        {
            frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }


        private void button_Bill_Banks_Click(object sender, EventArgs e)
        {
            frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();

        }

        private void button_Bill_Bills_Click(object sender, EventArgs e)
        {

        }

        private void button_Bill_Spending_Click(object sender, EventArgs e)
        {
            frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void button_Bill_BankProcess_Click(object sender, EventArgs e)
        {
            frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
            this.Hide();
        }

        private void button_Bill_Dashboard_Click(object sender, EventArgs e)
        {
            frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();

        }

        private void button_Bill_Settings_Click(object sender, EventArgs e)
        {
            frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        private void button_Bill_Exit_Click(object sender, EventArgs e)
        {
            ExitAll();
            System.Environment.Exit(0);
        }

        private void FrmBilling_FormClosing(object sender, FormClosingEventArgs e)
        {

            ExitAll();
            frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();

        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void ShowList()
        {
            dataGridView_BillView.DataSource = db.Bills.Select(x => new
            {
                FaturaID = x.BillId,
                FaturaBaslik = x.BillTitle,
                FaturaTutari = x.BillAmount,
                FaturaAraligi = x.BillPeriod,
            }).ToList();
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            ExitAll();
            ShowList();
        }

        private void button_Bill_ListBills_Click(object sender, EventArgs e)
        {
            ShowList();
        }

        private void button_Bill_AddBill_Click(object sender, EventArgs e)
        {
            string billTitle = textBox_Bill_BillTitle.Text;
            decimal billAmount = 0.0m;
            bool checkAmount = decimal.TryParse(textBox_Bill_BillAmount.Text, out billAmount);
            string billPeriod = textBox_Bill_BillPeriod.Text;
            if (checkAmount)
            {
                db.Bills.Add(new Bills
                {
                    BillTitle = billTitle,
                    BillAmount = billAmount,
                    BillPeriod = billPeriod,
                });
                db.SaveChanges();
                MessageBox.Show("Fatura başarılı bir şekilde eklendi.");
            }
            else
            {
                MessageBox.Show("Fatura tutarında bir sorun oldu. Lütfen kontrol edip tekrar deneyiniz!");
            }
            ShowList();
        }

        private void button_Bill_DeleteBill_Click(object sender, EventArgs e)
        {
            int billID = 0;
            bool checkBillID = int.TryParse(textBox_Bill_BillID.Text, out billID);           
            if (checkBillID)
            {
                var billEntity = db.Bills.Find(billID);
                db.Bills.Remove(billEntity);
                db.SaveChanges();
                MessageBox.Show($"FaturaID'i {billID} olan fatura başarı ile silindi.");
            }
            else {
                MessageBox.Show("Fatura ID tespitinde bir sorun oluştu. Lütfen kontrol edip tekrar deneyiniz.");
            }
            ShowList();
        }

        private void button_Bill_UpdateBill_Click(object sender, EventArgs e)
        {
            int billID = 0;
            bool checkBillID = int.TryParse(textBox_Bill_BillID.Text, out billID);

            decimal billAmount = 0.0m;
            bool checkAmount = decimal.TryParse(textBox_Bill_BillAmount.Text, out billAmount);
            if (!checkAmount)
            {
                MessageBox.Show("Fatura tutarında bir sorun oldu. Lütfen kontrol edip tekrar deneyiniz!");
                ShowList();
                return;
            }

            if (checkBillID)
            {
                var billEntity = db.Bills.Find(billID);
                billEntity.BillTitle = textBox_Bill_BillTitle.Text;
                billEntity.BillAmount = billAmount;
                billEntity.BillPeriod = textBox_Bill_BillPeriod.Text;
                db.SaveChanges();
                MessageBox.Show($"FaturaID'i {billID} olan fatura başarı ile güncellendi.");
            }
            else
            {
                MessageBox.Show("Fatura ID tespitinde bir sorun oluştu. Lütfen kontrol edip tekrar deneyiniz.");
            }
            ShowList();
        }

        private void panel_Bill_BillEnterValues_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FinancialCrm
{
    public partial class FrmBankProcess : Form
    {

        FrmBanks frmBanks;
        FrmBilling frmBilling;
        FrmCategories frmCategories;
        FrmSettings frmSettings;
        FrmSpendings frmSpendings;
        FrmLogin frmLogin;
        FrmDashboard frmDashboard;

        public FrmBankProcess()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void initializeAllFrm()
        {
            frmBanks = new FrmBanks();
            frmSettings = new FrmSettings();
            frmBilling = new FrmBilling();
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
            if (frmBilling != null)
            {
                frmBilling.Close();
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


        private void ShowList() { 
           dataGridView_CategoryList.DataSource = db.BankProcesses.Select(x => new { 
           ID = x.BankProcessId,
           Aciklama = x.Description,
           IslemTarihi = x.ProcessDate,
           IslemTipi = x.ProcessType,
           Tutar = x.Amount,
           Banka = db.Banks.Where(y => y.BankId == x.BankId).Select(c => c.BankTitle).FirstOrDefault()
           }).ToList();
        }


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
            
        }

        private void button_Dashboard_Click(object sender, EventArgs e)
        {
            frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
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

        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            ExitAll();
            comboBox_BankProcess_Banks.DataSource = db.Banks.ToList();
            comboBox_BankProcess_Banks.DisplayMember = "BankTitle";
            comboBox_BankProcess_Banks.ValueMember = "BankId";
            ShowList();

        }

        private void FrmBankProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitAll();
            frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void button_Categories_ListCategory_Click(object sender, EventArgs e)
        {
            ShowList();

        }

        private void button_Categories_AddCategory_Click(object sender, EventArgs e)
        {
            var description = textBox_BankProcess_Description.Text;
            DateTime dateTime = dateTimePicker_BankProcess_ProcessDate.Value;
            var amount = 0.0m;
            var processType = textBox_BankProcess_ProcessType.Text;
            int bankId = 0;
            bool checkBankIdCast = int.TryParse(comboBox_BankProcess_Banks.SelectedValue.ToString(), out bankId );
            bool checkAmountCast = decimal.TryParse(textBox_BankProcess_Amount.Text, out amount);
            if (!checkAmountCast)
            {
                MessageBox.Show("Tutarı kontrol ederek tekrar deneyiniz.");
            }

            if (!checkBankIdCast) {
                MessageBox.Show("Banka ID alımında sorun oluştu.");
            }

            db.BankProcesses.Add(new BankProcesses { 
            Description = description,
            ProcessDate = dateTime,
            ProcessType = processType,
            Amount = amount,
            BankId = bankId
            });
            db.SaveChanges();
            ShowList();
            MessageBox.Show("Banka Hareketi eklendi.");


        }

        private void button_Categories_UpdateCategory_Click(object sender, EventArgs e)
        {
            var bankProcessID = 0;
            bool checkBankProcessIDCast = int.TryParse(textBox_BankProcess_BankProcessID.Text, out bankProcessID);
            var bankProcessAmount = 0.0m;
            bool checkBankProcessAmountCast = decimal.TryParse(textBox_BankProcess_Amount.Text, out bankProcessAmount);

            int bankId = 0;
            bool checkBankIdCast = int.TryParse(comboBox_BankProcess_Banks.SelectedValue.ToString(), out bankId);

            if (!checkBankProcessIDCast) {
                MessageBox.Show("Lütfen ID'i kontrol edip tekrar deneyiniz");
                return;
            }

            if (!checkBankProcessAmountCast) {
                MessageBox.Show("Lütfen tutarı kontrol edip tekrar deneyiniz");
                return;
            }


            var processEntity = db.BankProcesses.Find(bankProcessID);
            if (processEntity != null)
            {
                processEntity.Description = textBox_BankProcess_Description.Text;
                processEntity.ProcessDate = dateTimePicker_BankProcess_ProcessDate.Value;
                processEntity.ProcessType = textBox_BankProcess_ProcessType.Text;
                processEntity.Amount = bankProcessAmount;
                processEntity.BankId = bankId;
                db.SaveChanges();
                ShowList();
                MessageBox.Show("Banka Hareketi güncellendi.");
            }
            else
            {
                MessageBox.Show("Böyle bir girdi bulunamadı!");
            }

           

        }

        private void button_BankProcess_DeleteBankProcess_Click(object sender, EventArgs e)
        {
            var bankProcessID = 0;
            bool checkBankProcessIDCast = int.TryParse(textBox_BankProcess_BankProcessID.Text, out bankProcessID);

            if (!checkBankProcessIDCast)
            {
                MessageBox.Show("Lütfen ID'i kontrol edip tekrar deneyiniz");
                return;
            }


            var processEntity = db.BankProcesses.Find(bankProcessID);           
            if (processEntity != null)
            {
                db.BankProcesses.Remove(processEntity);
                db.SaveChanges();
                ShowList();
                MessageBox.Show("Banka Hareketi silindi.");
            }
            else
            {
                MessageBox.Show("Böyle bir girdi bulunamadı!");
            }

        }
    }
}

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

namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {

        FrmBankProcess frmBankProcess;
        FrmBanks frmBanks;
        FrmBilling frmBilling;
        FrmCategories frmCategories;
        FrmDashboard frmDashboard;
        FrmSettings frmSettings;
        FrmLogin frmLogin;
        

        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();



        private void initializeAllFrm()
        {
            frmBankProcess = new FrmBankProcess();
            frmBanks = new FrmBanks();
            frmBilling = new FrmBilling();
            frmCategories = new FrmCategories();
            frmDashboard = new FrmDashboard();
            frmSettings = new FrmSettings();
            frmLogin = new FrmLogin();

        }

        private void ExitAll()
        {
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
            if (frmDashboard != null)
            {
                frmDashboard.Close();
            }
            if (frmSettings != null)
            {
                frmSettings.Close();
            }
            if (frmLogin != null)
            {
                frmLogin.Close();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            ExitAll();
            System.Environment.Exit(0);
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

        }

        private void button_BankProcess_Click(object sender, EventArgs e)
        {
            frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
            this.Hide();
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


        private void ShowList() {

            dataGridView_Spendings.DataSource = db.Spendings.Select(x => new
            {
                GiderID = x.SpendingId,
                GiderBaslik = x.SpendingTitle,
                HarcamaTutarı = x.SpendingAmount,
                GiderTarihi = x.SpendingDate,
                Kategori = db.Categories.Where(y => y.CategoryId == x.CategoryId).FirstOrDefault().CategoryName
            }).ToList();
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            RefreshStatistics();
            ExitAll();
            ShowList();

            comboBox_Spendings_Categories.DataSource = db.Categories.ToList();
            comboBox_Spendings_Categories.DisplayMember = "CategoryName";
            comboBox_Spendings_Categories.ValueMember = "CategoryId";






        }

        private void FrmSpendings_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitAll();
            frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void RefreshStatistics() {
            var result = (from sp in db.Spendings where sp.SpendingDate.Value.Month == DateTime.Now.Month select sp).ToList();

            var totalResult = db.Spendings.Where(x => (int)x.SpendingDate.Value.Month == DateTime.Now.Month).Sum(x => x.SpendingAmount);


            lbl_TotalSpendingInThisMonth.Text = result.Sum(y => y.SpendingAmount).ToString() + " ₺";

            lbl_TotalSpendingT.Text = db.Spendings.Sum(x => x.SpendingAmount).ToString() + " ₺";

            var mostSpendingCategoryAndValue = db.Spendings.GroupBy(s => s.CategoryId).Select(x => new
            {
                CategoryId = x.Key,
                TotalSpending = x.Sum(z => z.SpendingAmount)
            }).OrderByDescending(s => s.TotalSpending).FirstOrDefault();

            var mostSpendingCategoryName = db.Categories.Find(mostSpendingCategoryAndValue.CategoryId).CategoryName;

            lbl_MostSpendingCategory.Text = mostSpendingCategoryName + "  -  " + mostSpendingCategoryAndValue.TotalSpending.ToString() + " ₺";
        }

        private void timer_Statistics_Tick(object sender, EventArgs e)
        {
            RefreshStatistics();
        }

        private void button_Spending_ListSpendings_Click(object sender, EventArgs e)
        {
            ShowList();

        }

        private void button_Spendings_AddSpendings_Click(object sender, EventArgs e)
        {
            var amount = 0.0m;
            bool checkAmountCast = decimal.TryParse(textBox_Spendings_SpendingAmount.Text, out amount);

            if (!checkAmountCast) {
                MessageBox.Show("Tutarı kontrol edip tekrar deneyiniz.");
                return;
            }

            int categoryId = 0;
            bool checkIDCast = int.TryParse(comboBox_Spendings_Categories.SelectedValue.ToString(),out categoryId);

            if (!checkIDCast) {
                MessageBox.Show("Seçilen kategori okunamadı. Lüften tekrar seçip deneyiniz.");
                return;
            }

            db.Spendings.Add(new Spendings
            {
                SpendingTitle = textBox_Spendings_SpendingTitle.Text,
                SpendingAmount = amount,
                SpendingDate = dateTimePicker_Spendings_SpendingDate.Value,
                CategoryId = categoryId,
            });
            db.SaveChanges();

            MessageBox.Show("Gider başarılı şekilde eklendi.");
            ShowList();
        }

        private void button_Spendings_UpdateSpendings_Click(object sender, EventArgs e)
        {
            var spendingID = 0;
            bool checkSpendingIDCast = int.TryParse(textBox_Spendings_SpendingID.Text, out spendingID);

            if (!checkSpendingIDCast) {
                MessageBox.Show("ID'i kontrol edip tekrar deneyiniz.");
                return;            
            }

            var amount = 0.0m;
            bool checkAmountCast = decimal.TryParse(textBox_Spendings_SpendingAmount.Text, out amount);

            if (!checkAmountCast)
            {
                MessageBox.Show("Tutarı kontrol edip tekrar deneyiniz.");
                return;
            }

            int categoryId = 0;
            bool checkIDCast = int.TryParse(comboBox_Spendings_Categories.SelectedValue.ToString(), out categoryId);

            if (!checkIDCast)
            {
                MessageBox.Show("Seçilen kategori okunamadı. Lüften tekrar seçip deneyiniz.");
                return;
            }



            var spendingEntity = db.Spendings.Find(spendingID);

            if (spendingEntity != null)
            {
                spendingEntity.SpendingTitle = textBox_Spendings_SpendingTitle.Text;
                spendingEntity.SpendingAmount = amount;
                spendingEntity.SpendingDate = dateTimePicker_Spendings_SpendingDate.Value;
                spendingEntity.CategoryId = categoryId;
                db.SaveChanges();
                MessageBox.Show("Gider başarılı bir şekilde güncellendi.");
            }
            else
            {
                MessageBox.Show("Aranan değer bulunamadı.");
            }
            ShowList();
        }

        private void button_Spendings_DeleteSpendings_Click(object sender, EventArgs e)
        {

            var spendingID = 0;
            bool checkSpendingIDCast = int.TryParse(textBox_Spendings_SpendingID.Text, out spendingID);

            if (!checkSpendingIDCast)
            {
                MessageBox.Show("ID'i kontrol edip tekrar deneyiniz.");
                return;
            }

            var spendingEntity = db.Spendings.Find(spendingID);

            if (spendingEntity != null)
            {
                db.Spendings.Remove(spendingEntity);
                db.SaveChanges();
                MessageBox.Show("Gider başarılı bir şekilde silindi.");
            }
            else
            {
                MessageBox.Show("Aranan değer bulunamadı.");
            }
            ShowList();


        }
    }
}

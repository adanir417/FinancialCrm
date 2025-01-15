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
    public partial class FrmCategories : Form
    {
        FrmBankProcess frmBankProcess;
        FrmBilling frmBilling;
        FrmBanks frmBanks;
        FrmSettings frmSettings;
        FrmSpendings frmSpendings;
        FrmLogin frmLogin;
        FrmDashboard frmDashboard;


        public FrmCategories()
        {
            InitializeComponent();
        }


        private void initializeAllFrm()
        {
            frmBankProcess = new FrmBankProcess();
            frmSettings = new FrmSettings();
            frmBilling = new FrmBilling();
            frmBanks = new FrmBanks();
            frmDashboard = new FrmDashboard();
            frmSpendings = new FrmSpendings();
            frmLogin = new FrmLogin();

        }

        private void ExitAll()
        {
            if (frmBankProcess != null)
            {
                frmBankProcess.Close();
            }
            if (frmSettings != null)
            {
                frmSettings.Close();
            }
            if (frmBilling != null)
            {
                frmBilling.Close();
            }
            if (frmBanks != null)
            {
                frmBanks.Close();
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

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void ShowList() {
            dataGridView_CategoryList.DataSource = db.Categories.Select(x => new
            {
                KategoriID = x.CategoryId,
                KategoriAdi = x.CategoryName
            }).ToList();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            ExitAll();
            ShowList();
        }

        private void button_Categories_ListCategory_Click(object sender, EventArgs e)
        {
            ShowList();
        }

        private void button_Categories_AddCategory_Click(object sender, EventArgs e)
        {
            db.Categories.Add(new Categories { 
            CategoryName = textBox_Categories_CategoryName.Text
            });
            db.SaveChanges();
            ShowList();
        }

        private void button_Categories_DeleteCategory_Click(object sender, EventArgs e)
        {
            var categoryID = 0;
            bool checkIDCast = int.TryParse(textBox_Categories_CategoryID.Text, out categoryID);
            if (checkIDCast)
            {
                var categoryEntity = db.Categories.Find(categoryID);
                if (categoryEntity != null)
                {
                    db.Categories.Remove(categoryEntity);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Aranılan değer bulunamadı. ID eşleşmesi sağlandığından emin olunuz.", "Silme Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ID'i kontrol ederek tekrar deneyiniz.","Silme Sırasında Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            ShowList();


        }

        private void button_Categories_UpdateCategory_Click(object sender, EventArgs e)
        {

            var categoryID = 0;
            bool checkIDCast = int.TryParse(textBox_Categories_CategoryID.Text, out categoryID);
            if (checkIDCast)
            {
                var categoryEntity = db.Categories.Find(categoryID);
                if (categoryEntity != null)
                {
                    categoryEntity.CategoryName = textBox_Categories_CategoryName.Text;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Aranılan değer bulunamadı. ID eşleşmesi sağlandığından emin olunuz.", "Güncelleme Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ID'i kontrol ederek tekrar deneyiniz.", "Güncelleme Sırasında Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowList();
        }

        private void FrmCategories_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitAll();
            frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
           
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            ExitAll();
            System.Environment.Exit(0);
        }

        private void button_Categories_Click(object sender, EventArgs e)
        {

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
    }
}

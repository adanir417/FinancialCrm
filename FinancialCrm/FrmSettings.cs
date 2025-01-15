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
    public partial class FrmSettings : Form
    {
        FrmBankProcess frmBankProcess;
        FrmBanks frmBanks;
        FrmBilling frmBilling;
        FrmCategories frmCategories;
        FrmDashboard frmDashboard;       
        FrmSpendings frmSpendings;
        FrmLogin frmLogin;

        UserManager userManager;

        FinancialCrmDbEntities db;
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void initializeAllFrm()
        {
            frmBankProcess = new FrmBankProcess();
            frmBanks = new FrmBanks();
            frmBilling = new FrmBilling();
            frmCategories = new FrmCategories();           
            frmDashboard = new FrmDashboard();
            frmSpendings = new FrmSpendings();
            frmLogin = new FrmLogin();

        }

        private void ExitAll()
        {
            if (frmBankProcess != null) { 
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
            if (frmSpendings != null)
            { 
            frmSpendings.Close();
            }
            if (frmLogin != null) { 
            frmLogin.Close();
            }
        }

        private void ShowList() {
            dataGridView_Settings_UsersList.DataSource = db.Users.Select(x => new
            {
                KullaniciID = x.UserId,
                KullaniciAdi = x.Username
            }).ToList();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            db = new FinancialCrmDbEntities();
            userManager = new UserManager();
            ShowList();
            ExitAll();
            lbl_Settings_Description.Text = "Açıklamalar: \n" +
                "Kullanıcı eklerken Kullanıcı Adı ve Şifre girmeniz ve kullanıcı ekle butonuna basmanız yeterlidir. \n"
                + "Kullanıcı silerken tablo üzerinden silmek istediğiniz ID numarasını girmeniz \nve kullanıcı sil butonuna basmanız yeterlidir."
                ;
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
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
            
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            ExitAll();
            System.Environment.Exit(0);
        }

        private void button_Settings_AddUser_Click(object sender, EventArgs e)
        {

            userManager.RegisterUser(textBox_Settings_Username.Text.ToLower(), textBox_Settings_Password.Text);
            ShowList();
            
        }

        private void button_Settings_DeleteUser_Click(object sender, EventArgs e)
        {
            var userID = 0;
            bool checkIDCast = int.TryParse(textBox_Settings_UserID.Text, out userID);
            bool checkSuccess = false;
            if (checkIDCast && userID != 1 && userID != 0) {
              checkSuccess = userManager.DeleteUser(userID);
            }
            else
            {
                lbl_Settings_Warning.ForeColor = Color.Red;
                lbl_Settings_Warning.Text = "Silme başarısız";            
            }

            if (!checkSuccess)
            {
                lbl_Settings_Warning.ForeColor = Color.Red;
                lbl_Settings_Warning.Text = "Silme başarısız";
            }
            else
            {
                lbl_Settings_Warning.ForeColor = Color.White;
                lbl_Settings_Warning.Text = "Silme Başarılı";
            }

            ShowList();


        }
    }
}

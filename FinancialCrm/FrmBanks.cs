using FinancialCrm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{


    public partial class FrmBanks : Form
    {

        FrmBankProcess frmBankProcess;       
        FrmBilling frmBilling;
        FrmCategories frmCategories;
        FrmSettings frmSettings;
        FrmSpendings frmSpendings;
        FrmLogin frmLogin;
        FrmDashboard frmDashboard;



        public FrmBanks()
        {
            InitializeComponent();
            frmBilling = new FrmBilling();
            frmBilling.Hide();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();


        private void initializeAllFrm()
        {
            frmBankProcess = new FrmBankProcess();
            frmSettings = new FrmSettings();
            frmBilling = new FrmBilling();
            frmCategories = new FrmCategories();
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



       

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            ExitAll();

            // Banka Bakiyeleri
            decimal ziraatBankasiAmount = (decimal)db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(x => x.BankBalance).FirstOrDefault();
            decimal vakifBankasiAmount = (decimal)db.Banks.Where(x => x.BankTitle == "VakıfBank").Select(x => x.BankBalance).FirstOrDefault();
            decimal isBankasiAmount = (decimal)db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(x => x.BankBalance).FirstOrDefault();

            lbl_ZiraatInformationAmount.Text = ziraatBankasiAmount.ToString() + " ₺";
            lbl_VakifInformationAmount.Text = vakifBankasiAmount.ToString() + " ₺" ;
            lbl_İsBankasiInformationAmount.Text = isBankasiAmount.ToString() + " ₺";

            // Banka İşlemleri
            //var bankProcessList = db.BankProcesses.OrderByDescending(x => x.BankProcessId).ToList();
            //foreach (var process in bankProcessList) { 
            //Debug.WriteLine(process.Description);
            //}
            //var bankProcess1 = bankProcessList[0];
            //var bankProcess2 = bankProcessList[1];
            //var bankProcess3 = bankProcessList[2];
            //var bankProcess4 = bankProcessList[3];
            //var bankProcess5 = bankProcessList[4];

            //lbl_BankProcessOne.Text = "- " + bankProcess1.Description + " - " + bankProcess1.Amount + " - " + bankProcess1.ProcessDate.GetValueOrDefault().ToString("dd.MM.yyyy") + " - " + bankProcess1.ProcessType + " - " + db.Banks.Find(bankProcess1.BankId).BankTitle; 
            //lbl_BankProcessTwo.Text = "- " + bankProcess2.Description + " - " + bankProcess2.Amount + " - " + bankProcess2.ProcessDate.GetValueOrDefault().ToString("dd.MM.yyyy") + " - " + bankProcess2.ProcessType + " - " + db.Banks.Find(bankProcess2.BankId).BankTitle; 
            //lbl_BankProcessThree.Text = "- " + bankProcess3.Description + " - " + bankProcess3.Amount + " - " + bankProcess3.ProcessDate.GetValueOrDefault().ToString("dd.MM.yyyy") + " - " + bankProcess3.ProcessType + " - " + db.Banks.Find(bankProcess3.BankId).BankTitle; 
            //lbl_BankProcessFour.Text = "- " + bankProcess4.Description + " - " + bankProcess4.Amount + " - " + bankProcess4.ProcessDate.GetValueOrDefault().ToString("dd.MM.yyyy") + " - " + bankProcess4.ProcessType + " - " + db.Banks.Find(bankProcess4.BankId).BankTitle; 
            //lbl_BankProcessFive.Text = "- " + bankProcess5.Description + " - " + bankProcess5.Amount + " - " + bankProcess5.ProcessDate.GetValueOrDefault().ToString("dd.MM.yyyy") + " - " + bankProcess5.ProcessType + " - " + db.Banks.Find(bankProcess5.BankId).BankTitle; 

            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lbl_BankProcessOne.Text = "- " + bankProcess1.Description + " - " + bankProcess1.Amount + " - " + bankProcess1.ProcessDate.GetValueOrDefault().ToString("dd.MM.yyyy") + " - " + bankProcess1.ProcessType + " - " + db.Banks.Find(bankProcess1.BankId).BankTitle;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lbl_BankProcessTwo.Text = "- " + bankProcess2.Description + " - " + bankProcess2.Amount + " - " + bankProcess2.ProcessDate.GetValueOrDefault().ToString("dd.MM.yyyy") + " - " + bankProcess2.ProcessType + " - " + db.Banks.Find(bankProcess2.BankId).BankTitle;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lbl_BankProcessThree.Text = "- " + bankProcess3.Description + " - " + bankProcess3.Amount + " - " + bankProcess3.ProcessDate.GetValueOrDefault().ToString("dd.MM.yyyy") + " - " + bankProcess3.ProcessType + " - " + db.Banks.Find(bankProcess3.BankId).BankTitle;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lbl_BankProcessFour.Text = "- " + bankProcess4.Description + " - " + bankProcess4.Amount + " - " + bankProcess4.ProcessDate.GetValueOrDefault().ToString("dd.MM.yyyy") + " - " + bankProcess4.ProcessType + " - " + db.Banks.Find(bankProcess4.BankId).BankTitle;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            label8.Text = "- " + bankProcess5.Description + " - " + bankProcess5.Amount + " - " + bankProcess5.ProcessDate.GetValueOrDefault().ToString("dd.MM.yyyy") + " - " + bankProcess5.ProcessType + " - " + db.Banks.Find(bankProcess5.BankId).BankTitle;


        }

        private void button_Categories_Click(object sender, EventArgs e)
        {
            frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void button_banks_Click(object sender, EventArgs e)
        {
            
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

        private void button_Exit_Click(object sender, EventArgs e)
        {
            ExitAll();
            System.Environment.Exit(0);
        }

        private void FrmBanks_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitAll();
            System.Environment.Exit(0);
        }
    }
}

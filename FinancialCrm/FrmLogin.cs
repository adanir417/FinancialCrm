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
    public partial class FrmLogin : Form
    {
        UserManager userManager = new UserManager();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Enter() {
            string errorMessage = "";
            if (userManager.CheckLogin(textBox_Login_UserName.Text.ToLower(), textBox_Login_Password.Text, out errorMessage))
            {
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.Show();
                this.Hide();
            }
            else
            {
                lbl_Login_Warning.Text = errorMessage;
            }
        }

        private void button_Login_Enter_Click(object sender, EventArgs e)
        {
            Enter();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            textBox_Login_Password.PasswordChar = '*';
        }

        private void textBox_Login_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter();
            }
        }
    }
}

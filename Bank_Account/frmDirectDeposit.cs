using System;
using System.Windows.Forms;

namespace Bank_Account
{
    public partial class frmDirectDeposit : Form
    {
        public frmDirectDeposit()
        {
            InitializeComponent();
        }

        private void btnDepositOk_Click(object sender, EventArgs e)
        {
            string checking = txtDirectChecking.Text;
            double depositAmount = 0;

            if (double.TryParse(checking, out depositAmount))
            {
                frmAccount.directDeposit += depositAmount;
                this.Hide();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please enter a valid amount, " + frmLogin.Username + "!";
            }
        }

        private void btnDepositClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
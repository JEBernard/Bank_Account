using System;
using System.Windows.Forms;

namespace Bank_Account
{
    public partial class ManualDeposit : Form
    {
        private AccountsDataSetTableAdapters.AccountsTableAdapter accountAdapter =
            new AccountsDataSetTableAdapters.AccountsTableAdapter();

        public ManualDeposit()
        {
            InitializeComponent();
        }

        private void btnDepositOk_Click(object sender, EventArgs e)
        {
            string checking = txtDepositChecking.Text;
            double depositCheckingAmount = 0;

            try
            {
                if (double.TryParse(checking, out depositCheckingAmount))
                {
                    string username = frmLogin.Username;
                    accountAdapter.Deposit(username, "Checking", depositCheckingAmount);
                    this.Close();
                }
            }
            catch
            {
                toolStripStatusLabel1.Text = "Please enter a valid checking amount";
            }

            string savings = txtDepositSavings.Text;
            double depositSavingsAmount = 0;

            try
            {
                if (double.TryParse(savings, out depositSavingsAmount) || !frmAccount.openSavings)
                {
                    string username = frmLogin.Username;
                    accountAdapter.Deposit(username, "Savings", depositSavingsAmount);
                }
            }
            catch
            {
                toolStripStatusLabel1.Text = "Please enter a valid savings amount";
            }
        }

        private void ManualDeposit_Load(object sender, EventArgs e)
        {
            if (!frmAccount.openSavings)
            {
                txtDepositSavings.Enabled = false;
            }
            else
            {
                txtDepositSavings.Enabled = true;
            }
        }
    }
}
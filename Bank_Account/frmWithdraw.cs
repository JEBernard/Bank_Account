using System;
using System.Windows.Forms;

namespace Bank_Account
{
    public partial class frmWithdraw : Form
    {
        private AccountsDataSetTableAdapters.AccountsTableAdapter accountAdapter =
            new AccountsDataSetTableAdapters.AccountsTableAdapter();

        public frmWithdraw()
        {
            InitializeComponent();
        }

        private void btnWithdrawOK_Click(object sender, EventArgs e)
        {
            var selected = cboWithdraw.Text;

            // transfer from checking to savings
            if (selected == "Checking")
            {
                WithdrawFromChecking();
            }
            else if (selected == "Savings")
            {
                WithdrawFromSavings();
            }
        }

        private void WithdrawFromChecking()
        {
            string withdraw = txtWithdraw.Text;
            double withdrawAmount;
            if (double.TryParse(withdraw, out withdrawAmount) && withdrawAmount > 0)
            {
                if (withdrawAmount < frmAccount.CheckingBalance)
                {
                    accountAdapter.Deposit(frmLogin.Username, "Checking", withdrawAmount * -1, frmAccount.datetime);
                    toolStripStatusLabel1.Text = withdrawAmount.ToString("C") + " was withdrawn from Checking";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Insufficient Checking balance.";
                    return;
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Please enter a valid amount.";
            }
        }

        private void WithdrawFromSavings()
        {
            string withdraw = txtWithdraw.Text;
            double withdrawAmount;
            if (double.TryParse(withdraw, out withdrawAmount) && withdrawAmount > 0)
            {
                if (withdrawAmount < frmAccount.SavingsBalance - 4)
                {
                    accountAdapter.Deposit(frmLogin.Username, "Savings", withdrawAmount * -1, frmAccount.datetime);
                    toolStripStatusLabel1.Text = withdrawAmount.ToString("C") + " was withdrawn from Savings";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Insufficient Savings balance.";
                    return;
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Please enter a vlaid amount.";
            }
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            cboWithdraw.SelectedItem = "Checking";
            if (!frmAccount.openSavings)
            {
                cboWithdraw.Enabled = false;
            }
        }

        private void btnWithdrawClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
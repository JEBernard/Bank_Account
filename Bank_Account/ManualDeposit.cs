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
            double depositCheckingAmount;


            if (double.TryParse(checking, out depositCheckingAmount))
            {

                accountAdapter.Deposit(frmLogin.Username, "Checking", depositCheckingAmount, frmAccount.datetime);

                // TODO: print receipt 
            }
            else
            {
                toolStripStatusLabel1.Text = "Please enter a valid checking amount";
            }

            string savings = txtDepositSavings.Text;
            double depositSavingsAmount = 0;

          
                if (double.TryParse(savings, out depositSavingsAmount) || !frmAccount.openSavings)
                {
                    
                    accountAdapter.Deposit(frmLogin.Username, "Savings", depositSavingsAmount, frmAccount.datetime);
                    
                    // TODO: print receipt
                }    
                else
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

        private void btnDepositClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
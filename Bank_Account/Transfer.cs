using System;
using System.Windows.Forms;

namespace Bank_Account
{
    public partial class Transfer : Form
    {
        private AccountsDataSetTableAdapters.AccountsTableAdapter accountAdapter =
            new AccountsDataSetTableAdapters.AccountsTableAdapter();

        public Transfer()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!frmAccount.openSavings)
            {
                this.Close();
            }
            else {

                var selectedFrom = fromComboBox.Text;
                var selectedTo = toComboBox.Text;

                // transfer from checking to savings
                if (selectedFrom == "Checking" && selectedTo == "Savings")
                {
                    TransferFromChecking();
                }
                else if (selectedFrom == "Savings" && selectedTo == "Checking")
                {
                    TransferFromSavings();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransferFromChecking()
        {
            string transfer = txtTransfer.Text;
            double transferAmount;
            var selectedFrom = fromComboBox.Text;
            var selectedTo = toComboBox.Text;

            try
            {
                if (double.TryParse(transfer, out transferAmount) && selectedFrom == "Checking" && selectedTo == "Savings" && transferAmount > 0)

                    if (selectedFrom == "Checking" && selectedTo == "Savings" && frmAccount.CheckingBalance > transferAmount)
                    {
                        accountAdapter.Deposit(frmLogin.Username, "Savings", transferAmount, frmAccount.datetime);
                        accountAdapter.Deposit(frmLogin.Username, "Checking", transferAmount * -1, frmAccount.datetime);
                        toolStripStatusLabel1.Text = transferAmount.ToString("C") + " has been transfered from Checking to Savings";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Insufficient balance in Checking";
                    }
                else return;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Please enter a valid transfer amount";
            }
        }

        private void TransferFromSavings()
        {
            string transfer = txtTransfer.Text;
            double transferAmount;
            var selectedFrom = fromComboBox.Text;
            var selectedTo = toComboBox.Text;

            try
            {
                if (double.TryParse(transfer, out transferAmount) && selectedFrom == "Savings" && selectedTo == "Checking" && transferAmount > 0 )

                    if (frmAccount.SavingsBalance -4 > transferAmount)
                    {
                        accountAdapter.Deposit(frmLogin.Username, "Checking", transferAmount, frmAccount.datetime);
                        accountAdapter.Deposit(frmLogin.Username, "Savings", transferAmount * -1, frmAccount.datetime);
                        toolStripStatusLabel1.Text = transferAmount.ToString("C") + " has been transfered from Savings to Checking";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Insufficient balance in Savings";
                    }
                else return;
            }
            catch
            {
                toolStripStatusLabel1.Text = "Please enter a valid transfer amount";
            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            if (!frmAccount.openSavings)
            {
                fromComboBox.Enabled = false;
                toComboBox.Enabled = false;
                txtTransfer.Enabled = false;
                label1.Text = "Please open a savings account first."; 
               
            }
        }
    }
}
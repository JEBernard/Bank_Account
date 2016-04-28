using System;
using System.IO;
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

            if (double.TryParse(checking, out depositCheckingAmount) && depositCheckingAmount > 0)
            {
                accountAdapter.Deposit(frmLogin.Username, "Checking", depositCheckingAmount, frmAccount.datetime);

                double newbal = frmAccount.CheckingBalance += depositCheckingAmount;
                string rtext = depositCheckingAmount.ToString("C") + " was deposited in to Checking at " + frmAccount.datetime + " \n Your new balance is " + newbal.ToString("C");
                DialogResult result = MessageBox.Show("Would you like to print a receipt?", "Receipt", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string filename = String.Format("{0:yyyy-MM-dd}__{1}", DateTime.Now, "Checking.txt");
                    string path = Path.Combine(Directory.GetCurrentDirectory(), filename);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(rtext);
                        toolStripStatusLabel1.Text = "Receipt has printed successfully";
                        return; 
                    }
                }
                else
                {
                    toolStripStatusLabel1.Text = depositCheckingAmount.ToString("C") + " has been deposited in to Checking.";
                    return; 
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Please enter a valid checking amount";
               
            }


            string savings = txtDepositSavings.Text;
            double depositSavingsAmount = 0;

            if (double.TryParse(savings, out depositSavingsAmount) && frmAccount.openSavings && depositSavingsAmount > 0)
            {
                double newbal = frmAccount.SavingsBalance += depositSavingsAmount;
                string rtext = depositSavingsAmount.ToString("C") + " was deposited in to Savings at " + frmAccount.datetime + " \n Your new balance is " + newbal.ToString("C");

                accountAdapter.Deposit(frmLogin.Username, "Savings", depositSavingsAmount, frmAccount.datetime);

                DialogResult result = MessageBox.Show("Would you like to print a receipt?", "Receipt", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string filename = String.Format("{0:yyyy-MM-dd}__{1}", frmAccount.datetime, "Savings.txt");
                    string path = Path.Combine(Directory.GetCurrentDirectory(), filename);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(rtext);
                        toolStripStatusLabel1.Text = "Receipt has printed successfully";
                    }
                }
                else
                {
                    toolStripStatusLabel1.Text = depositSavingsAmount.ToString("C") + " has been deposited in to Savings."; 
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Please enter a valid savings amount";
                return; 
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
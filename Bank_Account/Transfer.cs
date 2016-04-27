using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string checkingTransfer = txtChecking.Text; 
            double checkingTransferAmount;
            string savingsTransfer = txtSavings.Text;
            double savingsTransferAmount; 

            var selectedFrom = fromComboBox.Text; 
            var selectedTo = toComboBox.Text; 
            
            // transfer from checking to savings
            if(double.TryParse(checkingTransfer, out checkingTransferAmount) &&  selectedFrom == "Checking" && selectedTo == "Savings") 
            {
                if(frmAccount.CheckingBalance > checkingTransferAmount)
                {
                    accountAdapter.Deposit(frmLogin.Username, "Savings", checkingTransferAmount, frmAccount.datetime);
                    accountAdapter.Deposit(frmLogin.Username, "Checking", checkingTransferAmount *-1, frmAccount.datetime); 
                    toolStripStatusLabel1.Text = checkingTransferAmount.ToString("C") + " has been transfered from Checking to Savings";
                }
                else 
                {
                    toolStripStatusLabel1.Text = "Insufficient balance in Checking"; 
                }
            }
            else 
            {
                toolStripStatusLabel1.Text = "Please enter a valid transfer amount";     
            }
            
            if(double.TryParse(savingsTransfer, out savingsTransferAmount) && selectedFrom == "Savings" && selectedTo == "Checking")
            {
                if(frmAccount.SavingsBalance > savingsTransferAmount)
                {
                    accountAdapter.Deposit(frmLogin.Username, "Checking", savingsTransferAmount, frmAccount.datetime); 
                    accountAdapter.Deposit(frmLogin.Username, "Savings", savingsTransferAmount *-1, frmAccount.datetime); 
                    toolStripStatusLabel1.Text = savingsTransferAmount.ToString("C") + " has been transfered from Savings to Checking"; 
                }
                else 
                {
                    toolStripStatusLabel1.Text = "Insufficient balance in Savings"; 
                }
            }
            else 
            {
                toolStripStatusLabel1.Text = "Please enter a valid transfer amount"; 
            }
        }
    }
}

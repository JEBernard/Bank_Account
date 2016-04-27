﻿using System;
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
            double currentCheckingamount; 
            double currentSavingsamount;
            // get current amounts
            currentCheckingamount = double.Parse(accountAdapter.GetTotal("Checking", frmLogin.Username).ToString()); 
            currentSavingsamount = double.Parse(accountAdapter.GetTotal("Savings", frmLogin.Username).ToString());
            
            var selectedFrom = fromComboBox.Text; 
            var selectedTo = toComboBox.Text; 
            
            // transfer from checking to savings
            if(double.TryParse(checkingTransfer, out checkingTransferAmount) &&  selectedFrom == "Checking" && selectedTo == "Savings") 
            {
                if(checkingamount > checkingtransfer)
                {
                    accountAdapter.Deposit(frmLogin.Username, "Savings", checkingamount, frmAccount.datetime);
                    accountAdapter.Deposit(frmLogin.Username, "Checking", chekcingamount *-1, frmAccount.datetime); 
                    toolStripStatusLabel1.Text = checkingamount.ToString("C") + " has been transfered from Checking to Savings";
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
                if(savingsamount > savingstransfer)
                {
                    accountAdapter.Deposit(frmLogin.Username, "Checking", savingsamount, frmAccount.datetime); 
                    accountAdapter.Deposit(frmLogin.Username, "Savings", savingsamount *-1, frmAccount.datetime); 
                    toolStripStatusLabel1.Text = savingsamount.ToString("C") + " has been transfered from Savings to Checking"; 
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

﻿using System;
using System.Windows.Forms;

/// <summary>
///  Bank Account - Final Project
///  Jason Bernard
/// </summary>

namespace Bank_Account
{
    public partial class frmLogin : Form
    {
        public string accountNumber; 
        
        private static string username;

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        private AccountsDataSetTableAdapters.AccountsTableAdapter accountAdapter =
            new AccountsDataSetTableAdapters.AccountsTableAdapter();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            username = txtLoginUserName.Text;
            string password = txtLoginPassword.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                toolStripStatusLabel1.Text = "Please enter a username and  password";
            }

            if (accountAdapter.Search(accountAdapter.GetData(), username, password) > 0)
            {
                frmAccount accountForm = new frmAccount();
                accountForm.ShowDialog(this);
                // display Account form
                this.Hide();
            }
            else if (accountAdapter.SearchUsername(accountAdapter.GetData(), username) > 0)
            {
                toolStripStatusLabel1.Text = "Invalid password";
            }
            else
            {
                toolStripStatusLabel1.Text = "Invalid credentials";
            }
        }
        
        private void GenerateAccountNumber()  
        // generate a random 6 digit number
        {
            Random generator = new Random(); 
            var x = generator.Next(0, 1000000); 
            accountNumber = x.ToString("000000"); 
        }

        private void Registration() // add validated Registration information and create new account

        {
            string Username = txtRegUserName.Text;
            string Password = txtRegPassword.Text;
            decimal CheckingBalance = 0m;
            decimal SavingsBalance = 0m;
            
            GenerateAccountNumber(); 
            // add new account to database
            try
            {
                accountAdapter.Insert(Username, Password, CheckingBalance, SavingsBalance, accountNumber); // TODO: update Account Number in data table to nvchar
                toolStripStatusLabel1.Text = "Account added successfully";
            }
            catch
            {
                toolStripStatusLabel1.Text = "Error adding account to database";
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Registration();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;

/// <summary>
///  Bank Account - Final Project
///  Jason Bernard
/// </summary>

namespace Bank_Account
{
    public partial class frmLogin : Form
    {
        private static string username;

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        private static string accountnumber;

        public static string AccountNumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
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

        private void Registration() // create new account

        {
            string Username = txtRegUserName.Text;
            string Password = txtRegPassword.Text;
            double CheckingBalance = 50;
            double SavingsBalance = 0;

            // generate account number

            Random generator = new Random();
            accountnumber = generator.Next(0, 1000000).ToString("D6");

            // add new account to database
            try
            {
                accountAdapter.NewAccount(Username, Password, CheckingBalance, SavingsBalance, accountnumber);
                accountAdapter.Deposit(Username, "Checking", CheckingBalance, DateTime.Now);
                accountAdapter.Deposit(Username, "Savings", SavingsBalance, DateTime.Now);
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
            System.Windows.Forms.Application.Exit();
        }
    }
}
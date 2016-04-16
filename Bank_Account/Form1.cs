using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/// <summary>
///  Bank Account - Final Project
///  Jason Bernard
/// </summary>


namespace Bank_Account
{


    struct Account  // Account structure with a Username and Password field
    {
        public string Username;
        public string Password;
    }

    public partial class frmLogin : Form
    {

        private LoginsDatasetTableAdapters.LoginsTableAdapter loginAdapter =
            new LoginsDatasetTableAdapters.LoginsTableAdapter();

        List<Account> AccountList = new List<Account>();
        public frmLogin()
        {
            InitializeComponent();

        }

        public int NumberUpperCase(string str)
        {
            int upper = 0; // the number of upper case in a passed string

            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upper++;
                }
            }

            //return number of upper case
            return upper;
        }

        public int NumberLowerCase(string str) // the number of lower case in a passed string
        {
            int lower = 0;

            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    lower++;
                }
            }
            return lower;
        }

        public int NumberDigits(string str) // the number of digits in a passed string
        {
            int digits = 0; // the number of digits 

            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }
            // return the number of digits
            return digits;
        }

        public int NumberPunctuation(string str) // the number of punctuations in a passed string
        {
            int punctuation = 0; // the number of punctuation

            foreach (char ch in str)
            {
                if (char.IsPunctuation(ch))
                {
                    punctuation++;
                }
            }
            // return the number of punctuation
            return punctuation;
        }

        private void Registration() // add validated Registration information and create new account

        {
          // add new account to database
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        

            const int MIN_LENGTH = 8;  // >8 characters
            string password = txtRegPassword.Text;

            if (String.IsNullOrEmpty(txtRegUserName.Text))
            {
                toolStripStatusLabel1.Text = "No name is entered";
            }

            else {

                if (password.Length >= MIN_LENGTH &&
                NumberUpperCase(password) >= 1 &&
                NumberLowerCase(password) >= 1 &&
                NumberDigits(password) >= 1 &&
                NumberPunctuation(password) >= 1)
                {
                    Registration();
                }
                else
                {
                    toolStripStatusLabel1.Text = "Password does not meet the requirements";
                }
            }

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtLoginUserName.Text;
            string password = txtRegPassword.Text;


            if (String.IsNullOrEmpty(txtLoginUserName.Text) || String.IsNullOrEmpty(txtLoginPassword.Text))
            {
                toolStripStatusLabel1.Text = "Please enter a username and  password";
            }
            else
            {
                toolStripStatusLabel1.Text = "Please enter a vaild login";
            }

            if (loginAdapter.Search(loginAdapter.GetData(), username, password) > 0)
            {
                // display Account form  
            }
            else if (loginAdapter.SearchByUsername(loginAdapter.GetData(), username) > 0)
            {
                toolStripStatusLabel1.Text = "Invalid password";
            }
            else
            {
                toolStripStatusLabel1.Text = "Invalid credentials";
            }
        }

        } 

    }
  


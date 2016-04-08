using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class frmLogin : Form
    {
        struct Account  // Account structure with a Username and Password field
        {
            public string Username;
            public string Password;
        }

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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLoginUsername.Text))
            {
                toolStripStatusLabel1.Text = "No name entered";
            }
            else {


                using (StreamReader sr = new StreamReader("Accounts.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data[0] == txtLoginUsername.Text.Trim() &&
                           data[1] == txtLoginPassword.Text.Trim())
                        {
                            // login successful

                            toolStripStatusLabel1.Text = "Welcome to the system, " + txtLoginUsername.Text;
                            break;

                            //close login form and show account form
                        }
                        // login unsuccessful

                        if (data[0] != txtLoginUsername.Text.Trim())
                        {
                            toolStripStatusLabel1.Text = "User name does not exist";
                        }
                        if (data[1] != txtLoginPassword.Text.Trim())
                        {
                            toolStripStatusLabel1.Text = "Incorrect Password";
                        }
                    }
                }
            }
        }

        private void Registration() // add validated Registration information and create new account

        {
            Account newAccount = new Account();
            newAccount.Username = txtRegUsername.Text;
            newAccount.Password = txtRegPassword.Text;
            AccountList.Add(newAccount); // add new account to list

            using (StreamWriter SW = new StreamWriter("Accounts.txt")) // store the new account in Accounts.txt file
            {
                for (int i = 0; i < AccountList.Count; i++)
                {
                    SW.WriteLine(AccountList[i].Username + "," + AccountList[i].Password);
                    toolStripStatusLabel1.Text = "Account created for: " + txtRegUsername.Text;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            /*
           validate textboxes and confirm passwords match
           Password Requirements: 
           - >8 characters
           - At least one upper case letter 
           - At least one lower case letter
           - At least one digit 
           - At least one punctuation symbol 
            */

            const int MIN_LENGTH = 8;  // >8 characters
            string password = txtRegPassword.Text;

            if (String.IsNullOrEmpty(txtRegUsername.Text))
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
        }
    }

    


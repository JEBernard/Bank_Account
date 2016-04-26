using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bank_Account
{
    partial class frmAccount : Form
    {
        private AccountsDataSetTableAdapters.AccountsTableAdapter accountAdapter =
            new AccountsDataSetTableAdapters.AccountsTableAdapter();

        public static bool openSavings = false;

        private static int savingsbal;

        public int AccountNumber;

        public static int SavingsBalance
        {
            get { return savingsbal; }
            set { savingsbal = value; }
        }

        private static decimal checkingbal;

        public static decimal CheckingBalance
        {
            get { return checkingbal; }
            set { checkingbal = value; }
        }

        private void manualDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open manual deposit form
            ManualDeposit deposit = new ManualDeposit();
            deposit.ShowDialog();
            //txtCheckingBal.Text = checkingbal.ToString("C"); // update checking total
            //txtSavingsBal.Text = savingsbal.ToString("C");  // update saving total
        }

        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            ReadData();

            openSavings = false;
        }

        public void ReadData()
        {
            string username = frmLogin.Username;
            double checkingamount;
            double savingsamount;
            lblWelcome.Text = "Welcome to your account " + username + ".";

            // TODO: fix connection string

            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JEBernard\Documents\Visual Studio 2015\Projects\Bank_Account\Bank_Account\bin\Debug\Accounts.mdf;Integrated Security = True");
            try
            {
                checkingamount = double.Parse(accountAdapter.GetTotal("Checking", username).ToString());
                if (checkingamount < 0)
                {
                    txtCheckingBal.Text = "0";
                }
                else
                {
                    txtCheckingBal.Text = checkingamount.ToString("C");
                }
            }
            catch
            {
                toolStripStatusLabel1.Text = "Error reading checking amount";
            }
            try
            {
                savingsamount = double.Parse(accountAdapter.GetTotal("Savings", username).ToString());
                if (savingsamount < 0)
                {
                    txtSavingsBal.Text = "0";
                }
                else
                {
                    txtSavingsBal.Text = savingsamount.ToString("C");
                }
            }
            catch
            {
                toolStripStatusLabel1.Text = "Error reading savings amount";
            }

            SqlCommand command =
              new SqlCommand("SELECT * FROM dbo.Accounts WHERE Username ='" + username + "'", connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                checkingbal = int.Parse((read["Checking Balance"]).ToString());
                savingsbal = int.Parse((read["Savings Balance"]).ToString());

                AccountNumber = int.Parse((read["Account Number"]).ToString());
                toolStripStatusLabel1.Text = AccountNumber.ToString();
            }
            read.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void OpenSavingsAccount()
        {
            if (openSavings)
            {
                toolStripStatusLabel1.Text = "A savings account has already been opened";
            }
            else if (checkingbal > 5)
            {
                string username = frmLogin.Username;
                accountAdapter.Deposit(username, "Savings", 5);
                checkingbal -= 5;
                accountAdapter.Deposit(username, "Checking", -5);
                openSavings = true;
            }
            else
            {
                toolStripStatusLabel1.Text = "A savings account requires a checking balance of $5.00";
            }
        }

        private void openSavingsAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSavingsAccount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void scanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //first check if check.txt file exists

            string dir = Directory.GetCurrentDirectory();

            if (File.Exists(dir + @"\check.txt"))
            {
                string accountNumber = AccountNumber.ToString();

                foreach (string line in File.ReadLines(dir + @"\check.txt"))
                {
                    if (line.Contains(accountNumber))
                    {
                        //toolStripStatusLabel1.Text = "Account matches";

                        // deposit the amount
                        double depositAmount = 0;
                        string amount = File.ReadLines(dir + @"\check.txt").Skip(2).Take(1).First();
                        amount = amount.Split(':')[1];

                        if (double.TryParse(amount, out depositAmount))
                        {
                            accountAdapter.Deposit(frmLogin.Username, "Checking", depositAmount);
                            ReadData();
                            toolStripStatusLabel1.Text = "Check deposited in the amount of " + depositAmount.ToString("C") + " in to checking";
                            break;
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Unable to read file.";
                        }
                    }
                }
            }
        }
    }
}
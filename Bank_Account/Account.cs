using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bank_Account
{
    partial class frmAccount : Form
    {
        string username = frmLogin.Username;
      private static  double checkingamount;
      private static  double savingsamount;

        public static double CheckingBalance
        {
            get { return checkingamount;  }
            set { checkingamount = value;  }
        }

        public static double SavingsBalance
        {
            get { return savingsamount; }
            set { savingsamount = value;  }
        }
        


        int c = 0;

       public static DateTime datetime = new DateTime();


        public static double directDeposit; 
        
        private AccountsDataSetTableAdapters.AccountsTableAdapter accountAdapter =
            new AccountsDataSetTableAdapters.AccountsTableAdapter();

        public static bool openSavings = false;


        private void manualDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open manual deposit form
            ManualDeposit deposit = new ManualDeposit();
            deposit.ShowDialog();
            
        }

        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            ReadData();
            lblWelcome.Text = "Welcome to your account " + username + ".";
            lblAccountNumber.Text = "Account Number: " + frmLogin.AccountNumber +".";
            lblTime.Text = DateTime.Now.ToString("MMM.dd, yyyy");
            datetime = Convert.ToDateTime(lblTime.Text); 
            openSavings = false;
        }

        public  void ReadData()
        {
            



            // TODO: fix connection string

            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JEBernard\Documents\Visual Studio 2015\Projects\Bank_Account\Bank_Account\bin\Debug\Accounts.mdf;Integrated Security = True");
           
                checkingamount = double.Parse(accountAdapter.GetTotal("Checking", username).ToString());
                txtCheckingBal.Text = checkingamount.ToString("C");
         
                savingsamount = double.Parse(accountAdapter.GetTotal("Savings", username).ToString());
                txtSavingsBal.Text = savingsamount.ToString("C");


            //SqlCommand command =
            //  new SqlCommand("SELECT * FROM dbo.Accounts WHERE Username ='" + username + "'", connection);
            //connection.Open();
            //SqlDataReader read = command.ExecuteReader();
            //while (read.Read())
            //{
            //    checkingbal = int.Parse((read["Checking Balance"]).ToString());
            //    savingsbal = int.Parse((read["Savings Balance"]).ToString());

            //    AccountNumber = int.Parse((read["Account Number"]).ToString());
            //    toolStripStatusLabel1.Text = ""; 
            //}
            //read.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void OpenSavingsAccount()
        {
            double checkingamount;
            double savingsamount;
            checkingamount = double.Parse(accountAdapter.GetTotal("Checking", username).ToString());
            savingsamount = double.Parse(accountAdapter.GetTotal("Savings", username).ToString());
           

            if (openSavings)
            {
                toolStripStatusLabel1.Text = "A savings account has already been opened";
            }
            else if (checkingamount > 5)
            {
                string username = frmLogin.Username;
                accountAdapter.Deposit(username, "Savings", 5, datetime);     
                accountAdapter.Deposit(username, "Checking", -5, datetime);
                openSavings = true;
                ReadData(); 
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
          
        }

        private void scanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //first check if check.txt file exists

            string dir = Directory.GetCurrentDirectory();

            if (File.Exists(dir + @"\check.txt"))
            {

                foreach (string line in File.ReadLines(dir + @"\check.txt"))
                {
                    if (line.Contains(frmLogin.AccountNumber))
                    {
                        //toolStripStatusLabel1.Text = "Account matches";

                        // deposit the amount
                        double depositAmount = 0;
                        string amount = File.ReadLines(dir + @"\check.txt").Skip(2).Take(1).First();
                        amount = amount.Split(':')[1];

                        if (double.TryParse(amount, out depositAmount))
                        {
                            accountAdapter.Deposit(frmLogin.Username, "Checking", depositAmount, datetime);
                            ReadData();
                            toolStripStatusLabel1.Text = "Check deposited in the amount of " + depositAmount.ToString("C") + " in to checking";
                            break;
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Error depositing check.";
                        }
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Account number does not match.";
                    }
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Unable to read file."; 
            }
        }

        private void frmAccount_Activated(object sender, EventArgs e)
        {
            ReadData(); 
        }

        private void advanceMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c++;
            // deposit direct deposit amount.  
            lblTime.Text = datetime.AddMonths(c).ToString("MMM. dd, yyyy");
            accountAdapter.Deposit(username, "Checking", directDeposit, datetime);
            ReadData(); 
            
        }

        private void setUpDirectoDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDirectDeposit dd = new frmDirectDeposit();
            dd.ShowDialog(); 
        }
    }
}
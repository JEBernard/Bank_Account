using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_Account
{
    partial class frmAccount : Form
    {
        public static bool openSavings = false;

        private static int savingsbal;

        public int AccountNumber;

        public static int SavingsBalance
        {
            get { return savingsbal; }
            set { savingsbal = value; }
        }

        private static int checkingbal;

        public static int CheckingBalance
        {
            get { return checkingbal; }
            set { checkingbal = value; }
        }

        private void manualDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open manual deposit form
            ManualDeposit deposit = new ManualDeposit();
            deposit.ShowDialog();
            txtCheckingBal.Text = checkingbal.ToString("C"); // update checking total
            txtSavingsBal.Text = savingsbal.ToString("C");  // update saving total
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
            lblWelcome.Text = "Welcome to your account " + username + ".";

            // TODO: fix connection string

            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JEBernard\Documents\Visual Studio 2015\Projects\Bank_Account\Bank_Account\bin\Debug\Accounts.mdf;Integrated Security = True");

            SqlCommand command =
              new SqlCommand("SELECT * FROM dbo.Accounts WHERE Username ='" + username + "'", connection); // TODO: Fix select query
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                checkingbal = int.Parse((read["Checking Balance"]).ToString());
                this.txtCheckingBal.Text = checkingbal.ToString("C");
                AccountNumber = int.Parse((read["Account Number"]).ToString());
                this.toolStripStatusLabel1.Text = AccountNumber.ToString();
            }
            read.Close();

            //  txtSavingsBal.Text = savingstotal.ToString("C");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void OpenSavingsAccount()
        {
            if (checkingbal > 5)
            {
                checkingbal -= 5;
                savingsbal += 5;
                txtSavingsBal.Text = savingsbal.ToString("C");
                txtCheckingBal.Text = checkingbal.ToString("C");
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
    }
}
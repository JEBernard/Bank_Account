using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_Account
{
    partial class frmAccount : Form
    {
        public static bool openSavings = false;

        private static double savingstotal;

        public static double savingsTotal
        {
            get { return savingstotal; }
            set { savingstotal = value; }
        }

        private static double checkingtotal;

        public static double checkingTotal
        {
            get { return checkingtotal; }
            set { checkingtotal = value; }
        }

        private void manualDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open manual deposit form
            ManualDeposit deposit = new ManualDeposit();
            deposit.ShowDialog();
            txtCheckingBal.Text = checkingtotal.ToString("C"); // update checking total
            txtSavingsBal.Text = savingstotal.ToString("C");  // update saving total
        }

        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            string username = frmLogin.Username;
            lblWelcome.Text = "Welcome to your account " + username + ".";

            int bal = 0;

            // TODO: fix connection string

            SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JEBernard\Documents\Visual Studio 2015\Projects\Bank_Account\Bank_Account\Accounts.mdf;Integrated Security = True");

            SqlCommand command =
              new SqlCommand("SELECT * FROM dbo.Accounts", connection); // TODO: Fix select query
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                bal = int.Parse((read["Checking Balance"]).ToString());
                this.txtCheckingBal.Text = bal.ToString("C");
            }
            read.Close();

            //  txtSavingsBal.Text = savingstotal.ToString("C");

            openSavings = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void OpenSavingsAccount()
        {
            if (checkingtotal > 5)
            {
                checkingtotal -= 5;
                savingstotal += 5;
                txtSavingsBal.Text = savingstotal.ToString("C");
                txtCheckingBal.Text = checkingtotal.ToString("C");
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
    }
}
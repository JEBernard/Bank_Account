using System;
using System.Windows.Forms;

namespace Bank_Account
{
    partial class frmAccount : Form
    {
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
        }

        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            button1.Focus();
            txtCheckingBal.Text = checkingtotal.ToString("C");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
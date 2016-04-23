using System;
using System.Windows.Forms;

namespace Bank_Account
{
    public partial class ManualDeposit : Form
    {
        public ManualDeposit()
        {
            InitializeComponent();
        }

        private void btnDepositOk_Click(object sender, EventArgs e)
        {
            int depositCheckingAmount = int.Parse(txtDepositChecking.Text); // TODO: add a try parse and validate blank
            frmAccount.CheckingBalance += depositCheckingAmount;
            string savings = txtDepositSavings.Text;
            int depositSavingsAmount = 0;
            try
            {
                if (int.TryParse(savings, out depositSavingsAmount) || !frmAccount.openSavings)
                {
                    frmAccount.SavingsBalance += depositSavingsAmount; // TODO: insert to database
                    this.Hide();
                }
            }
            catch
            {
                toolStripStatusLabel1.Text = "Please enter a valid savings amount";
            }
        }

        private void ManualDeposit_Load(object sender, EventArgs e)
        {
            if (!frmAccount.openSavings)
            {
                txtDepositSavings.Enabled = false;
            }
            else
            {
                txtDepositSavings.Enabled = true;
            }
        }
    }
}
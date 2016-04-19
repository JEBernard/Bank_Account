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
            double depositCheckingAmount = Double.Parse(txtDepositChecking.Text); // TODO: add a try parse
            frmAccount.checkingTotal += depositCheckingAmount;
            this.Hide();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            double depositCheckingAmount = Double.Parse(txtDepositChecking.Text);
            depositCheckingAmount += Totals.checkingTotal;
            this.Hide();
            frmAccount account = new frmAccount();
            account.Show(); 

        }
    }
}

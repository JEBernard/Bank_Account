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
    public partial class frmAccount : Form
    {
        public double checkingTotal;
        public double savingsTotal;

        private void manualDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open manual deposit form 
            ManualDeposit deposit = new ManualDeposit();
            this.Hide(); 
            deposit.Show(); 

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class PayrollFrame : Form
    {
        public PayrollFrame()
        {
            InitializeComponent();
        }

        private void interestRateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterestRate il = new InterestRate();
            il.Show();
        }

        private void salaryLoanComputationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryLoan sl = new SalaryLoan();
            sl.Show();
        }
    }
}

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
    public partial class SalaryLoan : Form
    {
        public SalaryLoan()
        {
            InitializeComponent();
        }

        private void SalaryLoan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String empName = nameinput.Text;
            int contribution = Convert.ToInt32(contributionInput.Text);
            int monthlySalary = Convert.ToInt32(monthSalaryInput.Text);
            int numberOfMonths = Convert.ToInt32(cb1.SelectedItem);

            Double totalLoanableAmount = Computation.amount(monthlySalary, contribution);
            Double totalInterestRate = Computation.InterestRate(numberOfMonths);
            Double totalInterest = Computation.interest(totalLoanableAmount, numberOfMonths, totalInterestRate);
            Double charge = Computation.charge(totalLoanableAmount);
            Double tamount = Computation.tamount(totalLoanableAmount, totalInterest, charge);
            Double amortization = Computation.amortization(tamount, numberOfMonths);

            txt5.Text = empName.ToString();
            txt6.Text = totalLoanableAmount.ToString("000.00");
            txt7.Text = charge.ToString("000.00");
            txt8.Text = ((totalInterestRate * 100) + "%".ToString());
            txt9.Text = totalInterest.ToString("000.00");
            txt0.Text = amortization.ToString("000.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameinput.Text = "";
            contributionInput.Text = "";
            monthSalaryInput.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt0.Text = "";
            txt9.Text = "";
            cb1.Text = "";
        }
    }
}

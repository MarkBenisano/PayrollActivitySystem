using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Computation
    {
        public static int pay(int a)
        {
            if (a == 0)
            {
                return 24;
            }

            else
            {
                return 36;
            }
        }
        public static Double amount(int Salary, int contri)
        {
            if (contri < 72)
            {
                return Salary * 1;
            }
            else
            {
                return Salary * 2;
            }
        }
        public static Double InterestRate(int rate)
        {
            if (rate == 24)
            {
                return 0.0082;
            }
            else
            {
                return 0.0092;
            }
        }
        public static Double interest(Double loan, Double pay, Double rate)
        {
            return loan * pay * rate;
        }

        public static Double charge(Double loan)
        {
            return 0.015 * loan;
        }
        public static Double tamount(Double loanamount, Double interest, Double charge)
        {
            return loanamount + interest + charge;
        }
        public static Double amortization(Double loan, Double monthpay)
        {
            return loan / monthpay;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestCalculatorUI
{
    class Interest
    {
        public double principalAmount;
        public double annualinterestRate;
        public int timePeriod;

        public double CalculateInterest()
        {
            return (principalAmount * (annualinterestRate / 100) * timePeriod) + principalAmount;
        }
    }
}

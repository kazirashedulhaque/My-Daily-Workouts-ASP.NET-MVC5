using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestCalculatorUI
{
    public partial class SimpleInterestCalculatorUI : Form
    {
        Interest simpleInterest = new Interest();
        public SimpleInterestCalculatorUI()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            simpleInterest.principalAmount = Convert.ToDouble(principalAmountTextBox.Text);
            simpleInterest.annualinterestRate = Convert.ToDouble(annualInterestRateTextBox.Text);
            simpleInterest.timePeriod = Convert.ToInt16(timePeriodTextBox.Text);

            double resultAmount = simpleInterest.CalculateInterest();

            resultTextBox.Text = Convert.ToString(resultAmount);
        }
    }
}

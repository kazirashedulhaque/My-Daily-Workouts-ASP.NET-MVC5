using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        Number aNumber = new Number();

        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void TwoNumbers()
        {
            aNumber.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aNumber.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            TwoNumbers();
            resultTextBox.Text = aNumber.AddNumber().ToString();
        }

        private void subtractButton_Click_1(object sender, EventArgs e)
        {
            TwoNumbers();
            resultTextBox.Text = aNumber.SubtractNumber().ToString();
        }

        private void multiplyButton_Click_1(object sender, EventArgs e)
        {
            TwoNumbers();
            resultTextBox.Text = aNumber.MultiplyNumber().ToString();
        }

        private void divideButton_Click_1(object sender, EventArgs e)
        {
            TwoNumbers();
            resultTextBox.Text = aNumber.DivideNumber().ToString();
        }
    }
}

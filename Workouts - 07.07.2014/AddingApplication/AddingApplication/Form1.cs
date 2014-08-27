using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(numberOne.Text);
            int num2 = Convert.ToInt16(numberTwo.Text);

            int result = num1 + num2;

            resultNumber.Text = result.ToString();
        }
    }
}

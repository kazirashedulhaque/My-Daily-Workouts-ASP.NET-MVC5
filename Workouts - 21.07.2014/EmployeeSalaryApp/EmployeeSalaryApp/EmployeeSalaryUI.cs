using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    { 
        Salary aSalary = new Salary();
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        
        private void showButton_Click(object sender, EventArgs e)
        {
            
            TotalSalary();
            MessageBox.Show(aSalary.CalculateSalary().ToString());

        }

        private void TotalSalary()
        {
            aSalary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.houseRent = aSalary.basicAmount*(Convert.ToDouble(houseRentTextBox.Text) / 100);
            aSalary.medicalAllowence = aSalary.basicAmount*(Convert.ToDouble(medicalAllowenceTextBox.Text)/100);
        }
    }
}

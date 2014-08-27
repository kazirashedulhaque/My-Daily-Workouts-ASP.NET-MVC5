using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApp
{
    public partial class EmployeeInformationUI : Form
    {
        Employee anEmployee = new Employee();
        
        public EmployeeInformationUI()
        {
            InitializeComponent();
        }

        

        private void showButton_Click(object sender, EventArgs e)
        {
            anEmployee.employeeID = employeeIdTextBox.Text;
            anEmployee.employeeName = employeeNameTextBox.Text;
            anEmployee.employeeSalary = Convert.ToDouble(employeeSalaryTextBox.Text);

            employeeIdTextBox.Text = "";
            employeeNameTextBox.Text = "";
            employeeSalaryTextBox.Text = "";

            MessageBox.Show("Employee Information" + "\nID: " + anEmployee.employeeID + "\nName: " + anEmployee.employeeName + "\nSalary: " + anEmployee.employeeSalary);
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            employeeIdTextBox.Text = anEmployee.employeeID;
            employeeNameTextBox.Text = anEmployee.employeeName;
            employeeSalaryTextBox.Text = anEmployee.employeeSalary.ToString();
        }
    }
}

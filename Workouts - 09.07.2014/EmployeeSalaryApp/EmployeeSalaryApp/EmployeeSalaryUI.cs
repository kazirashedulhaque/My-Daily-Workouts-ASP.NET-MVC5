using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        private string fileLocation = @"employeerecord.csv";

        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter(aStream);

            List<string> aEmployeeRecord = new List<string>();

            aEmployeeRecord.Add(employeeNameTextBox.Text);
            aEmployeeRecord.Add(idTextBox.Text);
            aEmployeeRecord.Add(salaryAmountTextBox.Text);

            aWriter.WriteRow(aEmployeeRecord);
            aStream.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);

            List<string> aEmployeeRecord = new List<string>();

            double total = 0;

            while (aReader.ReadRow(aEmployeeRecord))
            {
                string employeeName = aEmployeeRecord[0];
                string id = aEmployeeRecord[1];
                string salaryAmount = aEmployeeRecord[2];

                total += Convert.ToDouble(salaryAmount);

                employeeListBox.Items.Add(employeeName + " " + id + " " + salaryAmount);
                totalAmountTextBox.Text = Convert.ToString(total);
            }
            aStream.Close();
        }

        
    }
}

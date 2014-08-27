using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class StudentInformationUI : Form
    {
        Student aStudent = new Student();
        public StudentInformationUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;

            regNoTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";

            string fullName = aStudent.GetFullName();

            MessageBox.Show(fullName + ", your registration no. is " + aStudent.regNo);
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = aStudent.regNo;
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonNameApp
{
    public partial class PersonInformationUI : Form
    {
        private Person aPerson;

        public PersonInformationUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aPerson = new Person();
            SetNames();
            fullNameTextBox.Text = aPerson.GetFullName();
            reverseTextBox.Text = aPerson.GetReverseName();
        }

        private void SetNames()
        {
            aPerson.FirstName = firstNameTextBox.Text;
            aPerson.MiddleName = middleNameTextBox.Text;
            aPerson.LastName = lastNameTextBox.Text;
        }
    }
}

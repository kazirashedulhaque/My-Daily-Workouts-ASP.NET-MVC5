using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformation
{
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }

        string name;
        string fathersName;
        string mothersName;
        string address;

        private void Save_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            address = addressTextBox.Text;

            MessageBox.Show("Data Saved Successfully!");

            

        }

        private void View_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + name + "\nFather's Name: " + fathersName + "\nMother's Name: " + mothersName + "\nAddress: " + address);
        }
    }
}

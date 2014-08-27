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

namespace AddressBookApp
{
    public partial class AddressBookUI : Form
    {
        private string fileLocation = @"addressbook.csv";

        public AddressBookUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter(aStream);

            List<string> addressBook = new List<string>();

            addressBook.Add(nameTextBox.Text);
            addressBook.Add(emailTextBox.Text);
            addressBook.Add(personalContactTextBox.Text);
            addressBook.Add(homeContactTextBox.Text);
            addressBook.Add(homeAddressTextBox.Text);

            aWriter.WriteRow(addressBook);
            aStream.Close();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);

            List<string> addressBook = new List<string>();

            while (aReader.ReadRow(addressBook))
            {
                string name = addressBook[0];
                string email = addressBook[1];
                string personalContact = addressBook[2];
                string homeContact = addressBook[3];
                string homeAddress = addressBook[4];

                addressListBox.Items.Add(name + " " + email + " " + personalContact + " " + homeContact + " " + homeAddress);
            }
            aStream.Close();
        }
    }
}

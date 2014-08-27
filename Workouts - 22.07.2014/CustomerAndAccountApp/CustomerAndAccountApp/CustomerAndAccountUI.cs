using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAndAccountApp
{
    public partial class CustomerAndAccountUI : Form
    {
        private Account anAccount;
        private Customer aCustomer;
        private double amount;
        private string message;
        public CustomerAndAccountUI()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void saveCustomerInfoButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account(accountNumberEntryTextBox.Text, accountOpeningDateEntryTextBox.Text);
            aCustomer = new Customer(customerNameEntryTextBox.Text, customerEmailEntryTextBox.Text);
            aCustomer.CustomerAccount = anAccount;

            MessageBox.Show("Customer account has been succesfully created." + "\n\nCustomer Name: " +
                            aCustomer.CustomerName + "\nEmail: " + aCustomer.CustomerEmail + "\nAccount Number: " + anAccount.AccountNumber +
                            "\nOpening Date: " + anAccount.AccountOpeningDate);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account(Convert.ToDouble(amountTextBox.Text));

            amount = Convert.ToDouble(amountTextBox.Text);
            message = aCustomer.CustomerAccount.Deposit(amount);

            MessageBox.Show(message);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);


            if (Convert.ToDouble(amountTextBox.Text) > aCustomer.CustomerAccount.CurrentBalance)
            {

                MessageBox.Show("Insufficient balance available.");

            }
            else
            {
                message = aCustomer.CustomerAccount.Withdraw(amount);
                MessageBox.Show(message);
            }

        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            customerNameShowTextBox.Text = aCustomer.CustomerName;
            customerEmailShowTextBox.Text = aCustomer.CustomerEmail;
            customerAccountNumberShowTextBox.Text = aCustomer.CustomerAccount.AccountNumber;
            accountOpeningDatetShowTextBox.Text = aCustomer.CustomerAccount.AccountOpeningDate;
            currentBalanceShowTextBox.Text = aCustomer.CustomerAccount.CurrentBalance.ToString();
        }
    }
}

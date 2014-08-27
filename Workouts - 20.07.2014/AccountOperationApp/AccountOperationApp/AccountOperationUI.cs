using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountOperationUI : Form
    {
        private Account anAccountInfo = null;
        private double amount;
        private string message;

        public AccountOperationUI()
        {
            InitializeComponent();
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            anAccountInfo = new Account(accountNumberTextBox.Text, customerNameTextBox.Text);

            anAccountInfo.AccountNumber = accountNumberTextBox.Text;
            anAccountInfo.CustomerName = customerNameTextBox.Text;
            

            //anAccountInfo.SetNumber(accountNumberTextBox.Text);
            //anAccountInfo.CustomerName = customerNameTextBox.Text;

            //anAccountInfo.currentBalance = 0.00;

            MessageBox.Show("Customer account has been succesfully created." + "\n\nCustomer Name: " +
                            anAccountInfo.CustomerName + "\nAccount Number: " + anAccountInfo.AccountNumber +
                            "\nCurrent Balance: " + anAccountInfo.CurrentBalance + " Tk");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            anAccountInfo = new Account(Convert.ToDouble(amountTextBox.Text));

            amount = Convert.ToDouble(amountTextBox.Text);
            message = anAccountInfo.Deposit(amount);

            //anAccount.Balance = anAccount.Balance + amount;

            MessageBox.Show(message);
            
            //anAccountInfo.currentBalance = anAccountInfo.CurrentBalance + Convert.ToDouble(amountTextBox.Text);

            //MessageBox.Show("Current Balance: " + anAccountInfo.CurrentBalance + " Tk");

            //amountTextBox.Text = "";
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {


            amount = Convert.ToDouble(amountTextBox.Text);
            //message = anAccountInfo.Withdraw(amount);
            //MessageBox.Show(message);


            if (Convert.ToDouble(amountTextBox.Text) > anAccountInfo.CurrentBalance)
            {

                MessageBox.Show("Insufficient balance available.");

            }
            else
            {
                message = anAccountInfo.Withdraw(amount);
                MessageBox.Show(message);

                //anAccountInfo.CurrentBalance = anAccountInfo.CurrentBalance - Convert.ToDouble(amountTextBox.Text);

                //MessageBox.Show("Current Balance: " + anAccountInfo.CurrentBalance + " Tk");
            }

            
            

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            //anAccountInfo = new Account(accountNumberTextBox.Text, customerNameTextBox.Text);

            //message = anAccountInfo.CustomerName + ", your acc no: " + anAccountInfo.AccountNumber + " and it's balance is: " + anAccountInfo.CurrentBalance;
            anAccountInfo.AccountNumber = accountNumberTextBox.Text;
            anAccountInfo.CustomerName = customerNameTextBox.Text;

            MessageBox.Show("Your Account Information" + "\n\nCustomer Name: " + anAccountInfo.CustomerName + "\nAccount Number: " +
                            anAccountInfo.AccountNumber + "\nCurrent Balance: " + anAccountInfo.CurrentBalance + " Tk");
        }
    }
}

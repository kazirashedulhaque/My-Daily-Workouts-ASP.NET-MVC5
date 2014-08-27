using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    class Account
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public double CurrentBalance { get; private set; }

        public Account(string accountNumber, string customerName)
        {
            this.AccountNumber = accountNumber;
            this.CustomerName = customerName;   
        }

        public Account(double amount)
        {
            this.Amount = amount;
        }

        public Account()
        {

        }


        public string Deposit(double amount)
        {
            CurrentBalance = CurrentBalance + amount;
            return "Balance Diposited." + "\nCurrent Balance: " + CurrentBalance + " Tk";
        }

        public string Withdraw(double amount)
        {
            CurrentBalance = CurrentBalance - amount;
            return "Balance Withdrawn." + "\nCurrent Balance: " + CurrentBalance + " Tk";
        }

    }
}

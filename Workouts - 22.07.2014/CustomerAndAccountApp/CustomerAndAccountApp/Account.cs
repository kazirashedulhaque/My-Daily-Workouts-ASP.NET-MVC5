using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountApp
{
    class Account
    {
        public string AccountNumber { get; set; }
        public string AccountOpeningDate { get; set; }
        public double Amount { get; set; }
        public double CurrentBalance { get; private set; }

        public Account(string accountNumber, string accountOpeningDate):this()
        {
            this.AccountNumber = accountOpeningDate;
            this.AccountOpeningDate = accountOpeningDate;
        }

        public Account()
        {
            CurrentBalance = 0;
        }

        public Account(double amount)
        {
            this.Amount = amount;
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

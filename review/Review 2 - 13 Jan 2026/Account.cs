using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account_Manager
{
    internal class Account
    {
        private int accountNumber;
        private int pin;
        private double balance;

        //101, 1234, 5000
        public Account(int accountNumber, int pin, double balance)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
            this.balance = balance;
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public int GetPin()
        {
            return pin;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                return true;
            }
            return false;
        }
    }
}

//Methods – Bank Account Manager
//1. Scenario: A banking app needs to perform operations like deposit, withdraw, and check balance for a user.
//● Problem: Design a BankAccount class with :
//● Fields/Properties: AccountNumber, Balance.
//● Methods: Deposit(double), Withdraw(double), CheckBalance().
//● Include logic to prevent overdraft.


//Roles:  Bank , Manager , User

using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account_Manager
{
    internal class Bank
    {
        private string bankName;
        private string bankBranch;
        private double IFSCCode;

        public Bank(string bankName, string bankBranch, double IFSCCode)
        {
            this.bankName = bankName;
            this.bankBranch = bankBranch;
            this.IFSCCode = IFSCCode;
        }

        public string GetBankName()
        {
            return bankName;
        }

        public string GetBankBranch()
        {
            return bankBranch;
        }

        public double GetIFSCCode()
        {
            return IFSCCode;
        }
    }
}

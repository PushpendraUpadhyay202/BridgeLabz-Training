using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Runtime.CompilerServices;

namespace Bank_Account_Manager
{
    internal class BankUser : IBankOperations
    {
        private Account account;

        public BankUser(Account account)
        {
            this.account = account;
        }

        public void Login()
        {
            bool isAuthenticate = false;

            while (!isAuthenticate)
            {
                Console.Write("Enter Account Number: ");
                int accNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter PIN: ");
                int pin = Convert.ToInt32(Console.ReadLine());

                if (accNo == account.GetAccountNumber() && pin == account.GetPin())
                {
                    Console.WriteLine("User Login Successful");
                    isAuthenticate = true;
                    ShowMenu();
                }
                else
                {
                    Console.WriteLine("Invalid Account Number or PIN");
                }
            }
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- User Menu ---");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Balance: " + account.GetBalance());
                        break;
                    case 2:
                        Console.Write("Enter Amount to Deposit: ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(amount);
                        Console.WriteLine("Amount Deposited Successfully");
                        break;
                    case 3:
                        Console.Write("Enter Amount to Withdraw: ");
                        double bal = Convert.ToDouble(Console.ReadLine());

                        if (account.Withdraw(bal))
                        {
                            Console.WriteLine("Withdraw Successful");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...............");
                        return;
                    default:
                        Console.WriteLine("Enter from 1 to 4 only");
                        break;
                }
            }
        }
    }
}


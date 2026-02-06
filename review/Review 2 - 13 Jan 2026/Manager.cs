using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Bank_Account_Manager
{
    internal class Manager : IBankOperations
    {
        private static string emailId = "emailid@gmail.com";
        private static string password = "password";

        public void Login()
        {
            bool isAuthenticate = false;
            while (!isAuthenticate)
            {
                Console.Write("Enter Manager Email: ");
                string email = Console.ReadLine();

                Console.Write("Enter Manager Password: ");
                string pass = Console.ReadLine();

                if (email == emailId && pass == password)
                {
                    Console.WriteLine("Manager Login Successful");
                    isAuthenticate = true;
                    ShowMenu();
                }
                else
                {
                    Console.WriteLine("Invalid Manager Credentials");
                }
            }
        }


        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Manager Menu ---");
                Console.WriteLine("1. View Bank Details");
                Console.WriteLine("2. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Bank bank = new Bank("SBI", "Baldeo", 111);
                        Console.WriteLine("Bank Name  : " + bank.GetBankName());
                        Console.WriteLine("Branch     : " + bank.GetBankBranch());
                        Console.WriteLine("IFSC Code  : " + bank.GetIFSCCode());
                        break;
                    case 2:
                        Console.WriteLine("Exiting Program...................");
                        return;
                    default:
                        Console.WriteLine("Enter from 1 to 2 only");
                        break;
                }
                
            }
        }
    }
}


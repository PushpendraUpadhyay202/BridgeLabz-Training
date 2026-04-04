using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Bank_Account_Manager
{
    internal class Menu
    {
        public static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- BANK ACCOUNT MANAGER ---");
                Console.WriteLine("1. Manager Login");
                Console.WriteLine("2. User Login");
                Console.WriteLine("3. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        IBankOperations manager = new Manager();
                        manager.Login();
                        break;
                    case 2:
                        Account account = new Account(101, 1234, 5000);
                        IBankOperations user = new BankUser(account);
                        user.Login();
                        break;
                    case 3:
                        Console.WriteLine("Exiting Program............");
                        return;
                    default:
                        Console.WriteLine("Enter the Option from 1 to 3 only");
                        break;
                }  
            }
        }
    }
}


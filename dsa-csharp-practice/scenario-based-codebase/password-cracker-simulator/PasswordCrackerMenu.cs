using System;
using System.Collections.Generic;
using System.Text;

namespace Password_Cracker_Simulator
{
    internal class PasswordCrackerMenu
    {
        private IPasswordCracker utility;

        public PasswordCrackerMenu()
        {
            utility = new PasswordCrackerUtility();
        }

        public void Menu()
        {
            Console.WriteLine("\n==============    WELCOME TO PASSWORD CRACKER SYSTEM    ================\n");
            int choice;
            do
            {
                Console.WriteLine("1. Set A Password");
                Console.WriteLine("2. Crack Password");
                Console.WriteLine("0. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.SetPassword();
                        break;
                    case 2:
                        utility.CrackPassword();
                        break;
                    case 0:
                        Console.WriteLine("Exiting Program................");
                        return;
                }

            } while (choice != 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Adhar_Number_Sorting
{
    internal class AdharMenu
    {
        private IAdhar utility;

        public AdharMenu()
        {
            utility = new AdharUtility();
        }

        public void Menu()
        {
            Console.WriteLine("=============    WELCOME TO ADHAR CENTER   =============");

            int choice;
            do
            {
                Console.WriteLine("1. Add Adhar");
                Console.WriteLine("2. Search Adhar");
                Console.WriteLine("3. Display All Adhar");
                Console.WriteLine("0. Exit");

                Console.Write("Enter option : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddAdhar();
                        break;
                    case 2:
                        utility.SearchAdhar();
                        break;
                    case 3:
                        utility.DisplayAllAdhar();
                        break;
                    case 0:
                        Console.WriteLine("Exiting Program.............");
                        return;
                }

            } while (choice != 0);

        }
    }
}

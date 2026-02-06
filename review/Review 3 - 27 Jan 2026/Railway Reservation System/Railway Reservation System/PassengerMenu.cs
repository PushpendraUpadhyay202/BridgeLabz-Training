using System;
using System.Collections.Generic;
using System.Text;

namespace Railway_Reservation_System
{
    internal class PassengerMenu
    {
        private IPassenger utility;
        public PassengerMenu()
        {
            utility = new PassengerUtility();
        }
        public void Menu()
        {

            while (true)
            {
                Console.WriteLine("\n==============     WELCOME TO RAILWAY RESERVATION SYSTEM   =================\n");
                Console.WriteLine("1. Add Passenger");
                Console.WriteLine("2. Sort Passenger");
                Console.WriteLine("3. Search Passenger");
                Console.WriteLine("4. Display All Passengers");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddPassenger();
                        break;
                    case 2:
                        utility.SortPassenger();
                        Console.WriteLine("Passenger List Sorted Successfully");
                        break;
                    case 3:
                        utility.SortPassenger();
                        utility.SearchPassenger();
                        break;
                    case 4:
                        utility.DisplayPassengers();
                        break;
                    case 0:
                        Console.WriteLine("\nExiting Program.................\n");
                        return;
                    default:
                        Console.WriteLine("Enter Valid Option");
                        break;
                }
            }
        }
    }
}

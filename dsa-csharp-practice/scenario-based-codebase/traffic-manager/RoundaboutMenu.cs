using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Manager
{
    internal class RoundaboutMenu
    {
        private IRoundabout roundaboutUtility;

        public void ShowRoundaboutMenu()
        {
            roundaboutUtility = new RoundaboutUtility();
            int choice;

            do
            {
                Console.WriteLine("\n==== WELCOME TO ROUNDABOUT MANAGER ====\n");
                Console.WriteLine("1. Display Roundabout State");
                Console.WriteLine("2. Add a vehicle in Roundabout");
                Console.WriteLine("3. Remove a vehicle from Roundabout");
                Console.WriteLine("4. Add a vehicle in queue.");
                Console.WriteLine("5. Remove vehicle from queue and add to roundabout.");
                Console.WriteLine("0. Exit");
                Console.Write("Please enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                switch (choice)
                {
                    case 1:
                        roundaboutUtility.DisplayRoundabout();
                        break;

                    case 2:
                        roundaboutUtility.AddVehicleInRoundabout();
                        break;

                    case 3:
                        roundaboutUtility.RemoveVehicleFromRoundabout();
                        break;

                    case 4:
                        roundaboutUtility.AddVehicleInQueue();
                        break;
                    case 5:
                        roundaboutUtility.RemoveVehicleFromQueue();
                        break;
                }
            } while (choice != 0);
        }
    }
}

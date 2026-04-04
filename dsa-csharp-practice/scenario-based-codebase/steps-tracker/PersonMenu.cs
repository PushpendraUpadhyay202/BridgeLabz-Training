using System;
using System.Collections.Generic;
using System.Text;

namespace Steps_Tracker
{
    internal class PersonMenu
    {
        private IPerson utility;

        public PersonMenu()
        {
            utility = new PersonImpl();
        }
        public void ShowMenu()
        {
            Console.WriteLine("=============     WELCOME TO STEPS COUNTER     ===============");
            int choice;
            do
            {
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. Update Existing Person Steps Count ");
                Console.WriteLine("3. Show LeaderBoard");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddPerson();
                        break;
                    case 2:
                        utility.UpdateExistingPersonStepCount();
                        break;
                    case 3:
                        utility.ShowLeaderBoard();
                        break;
                    case 0:
                        Console.WriteLine("Exiting Program...............");
                        return;
                }
            }
            while (choice != 0);
        }
    }
}

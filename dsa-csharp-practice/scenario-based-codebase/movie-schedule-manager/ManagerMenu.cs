using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Schedule_Manager
{
    internal class ManagerMenu
    {
        public IManager utility;

        public ManagerMenu()
        {
            utility = new ManagerImpl();
        }
        public void Menu()
        {
            Console.WriteLine("===========   Movie Scheduler   ==============");

            bool isAuthenticate = false;
            while (!isAuthenticate)
            {
                Console.Write("Enter the emailId: ");
                string emailId = Console.ReadLine();
                Console.Write("\nEnter the password: ");
                string password = Console.ReadLine();

                if (emailId != "" && password != "")
                {
                    if (utility.Authenticate(emailId, password))
                    {
                        Console.WriteLine("Successfully Autheticated");
                        isAuthenticate = true;
                    }
                    else
                    {
                        Console.WriteLine("Authenticate Failed");
                        Console.WriteLine("Please try again");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter Valid Credentials ");

                }
            }

            while (true)
            {
                Console.WriteLine("1.Add Movie");
                Console.WriteLine("2.Search Movie");
                Console.WriteLine("3.Display All Movies");
                Console.WriteLine("4.Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddMovie();
                        break;
                    case 2:
                        utility.SearchMovie();
                        break;
                    case 3:
                        utility.DisplayAllMovies();
                        break;
                    case 4:
                        Console.WriteLine("\nExiting Program..............");
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Enter option from 1 to 4 Only");
                        break;
                }
            }
        }
    }
}

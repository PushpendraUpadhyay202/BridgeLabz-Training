using System;
using System.Collections.Generic;
using System.Text;

namespace Railway_Reservation_System
{
    internal class PassengerUtility : IPassenger
    {
        // ADD PASSENGER
        List<Passenger> passengers = new List<Passenger>();
        public void AddPassenger()
        {
            Console.Write("Enter PNR (max 4 digits): ");
            int pnr = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Distance (km): ");
            double distance = double.Parse(Console.ReadLine());

            Passenger p;

            if (age >= 60)
                p = new SeniorPassenger(pnr, name, age, distance);
            else
                p = new NormalPassenger(pnr, name, age, distance);

            passengers.Add(p);
            Console.WriteLine("Passenger added successfully.");
        }

        // SELECTION SORT BY PNR NUMBER
        public void SortPassenger()
        {
            for (int i = 0; i < passengers.Count - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < passengers.Count; j++)
                {
                    Passenger p1 = passengers[j];
                    Passenger p2 = passengers[minIndex];

                    if (p1.PnrNumber < p2.PnrNumber)
                        minIndex = j;
                }

                if (minIndex != i)
                {
                    Passenger temp = passengers[i];
                    passengers[i] = passengers[minIndex];
                    passengers[minIndex] = temp;
                }
            }
        }


        // BINARY SEARCH
        public void SearchPassenger()
        {
            Console.Write("Enter PNR to search: ");
            int target = int.Parse(Console.ReadLine());

            int left = 0;
            int right = passengers.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                Passenger midPassenger = passengers[mid];

                if (midPassenger.PnrNumber == target)
                {
                    Console.WriteLine("Passenger Found (Binary Search):");
                    midPassenger.PrintDetails();
                    return;
                }
                else if (target < midPassenger.PnrNumber)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            Console.WriteLine("Passenger not found.");
        }

        //DISPLAY ALL PASSENGERS DETAILS
        public void DisplayPassengers()
        {
            for (int i = 0; i < passengers.Count; i++)
            {
                passengers[i].PrintDetails();
            }
        }
    }
}

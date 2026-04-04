using System;

class BusRouteDistanceTracker
{
    static void Main()
    {
        double totalDistance = 0;
        double distancePerStop = 2.5; // distance added at each stop (in km)
        int stopNumber = 1;
        string choice;

        Console.WriteLine("🚌 Bus Route Distance Tracker");
        Console.WriteLine("-----------------------------");

        while (true)
        {
            Console.WriteLine("Stop " + stopNumber + " reached.");
            totalDistance += distancePerStop;

            Console.WriteLine("Distance added: " + distancePerStop + " km");
            Console.WriteLine("Total distance travelled: " + totalDistance + " km");

            Console.Write("Do you want to get off at this stop? (yes/no): ");
            choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                Console.WriteLine("Passenger got off the bus.");
                break; // exit loop on user confirmation
            }

            stopNumber++;
            Console.WriteLine();
        }

        Console.WriteLine("-----------------------------");
        Console.WriteLine("Final distance travelled: " + totalDistance + " km");
        Console.WriteLine("Thank you for using the Bus Route Distance Tracker!");
    }
}

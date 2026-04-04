using System;

internal class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car(1, "Amit", 15, "CAR-101"),
            new Bike(2, "Rohit", 10, "BIKE-202"),
            new Auto(3, "Suresh", 12, "AUTO-303")
        };

        ProcessRides(vehicles, 10);
    }

    static void ProcessRides(List<Vehicle> vehicles, double distance)
    {
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();

            if (vehicle is IGPS gps)
            {
                gps.UpdateLocation("City Center");
                Console.WriteLine("Current Location: " + gps.GetCurrentLocation());
            }

            double fare = vehicle.CalculateFare(distance);
            Console.WriteLine($"Distance: {distance} km");
            Console.WriteLine($"Total Fare: {fare}");
        }
    }
}

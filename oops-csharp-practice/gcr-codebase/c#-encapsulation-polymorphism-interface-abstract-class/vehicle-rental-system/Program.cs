using System;

internal class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR123", 2000, "CAR-INS-001"),
            new Bike("BIKE456", 800, "BIKE-INS-002"),
            new Truck("TRUCK789", 5000, "TRUCK-INS-003")
        };

        CalculateCosts(vehicles, 5);
    }

    static void CalculateCosts(List<Vehicle> vehicles, int days)
    {
        foreach (Vehicle vehicle in vehicles)
        {
            double rentalCost = vehicle.CalculateRentalCost(days);
            double insuranceCost = 0;

            if (vehicle is IInsurable insurable)
            {
                insuranceCost = insurable.CalculateInsurance();
                Console.WriteLine(insurable.GetInsuranceDetails());
            }

            Console.WriteLine(
                $"Vehicle: {vehicle.GetType()} | Number: {vehicle.GetVehicleNumber()}"
            );
            Console.WriteLine($"Rental Cost ({days} days): {rentalCost}");
            Console.WriteLine($"Insurance Cost: {insuranceCost}");
        }
    }
}

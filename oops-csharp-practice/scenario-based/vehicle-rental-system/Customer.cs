using System;

public class Customer
{
    private string name;

    public Customer(string name)
    {
        this.name = name;
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        double amount = vehicle.CalculateRent(days);
        Console.WriteLine($"{name} rented vehicle for {days} days.");
        Console.WriteLine("Total Rent: " + amount);
    }
}

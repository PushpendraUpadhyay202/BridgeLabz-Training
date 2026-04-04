using System;

internal abstract class Vehicle
{
    protected int vehicleId;
    protected string driverName;
    protected double ratePerKm;
    private string vehicleRegistrationNumber;

    protected Vehicle(int vehicleId, string driverName, double ratePerKm, string registrationNumber)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
        this.vehicleRegistrationNumber = registrationNumber;
    }
    public int GetVehicleId()
    {
        return vehicleId;
    }

    public string GetDriverName()
    {
        return driverName;
    }

    public double GetRatePerKm()
    {
        return ratePerKm;
    }

    protected string GetRegistrationNumber()
    {
        return vehicleRegistrationNumber;
    }

   
    public void GetVehicleDetails()
    {
        Console.WriteLine(
            $"Vehicle ID: {vehicleId} | Driver: {driverName} | Rate/Km: {ratePerKm}"
        );
    }

    public abstract double CalculateFare(double distance);
}

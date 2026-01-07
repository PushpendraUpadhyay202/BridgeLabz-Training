using System;

internal abstract class Vehicle
{
    protected string vehicleNumber;
    protected string type;
    protected double rentalRate;
    private string insurancePolicyNumber;

    protected Vehicle(string vehicleNumber, string type, double rentalRate, string policyNumber)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
        this.insurancePolicyNumber = policyNumber;
    }

    public string GetVehicleNumber()
    {
        return vehicleNumber;
    }

    public string GetType()
    {
        return type;
    }

    public double GetRentalRate()
    {
        return rentalRate;
    }

    protected string GetInsurancePolicyNumber()
    {
        return insurancePolicyNumber;
    }

    public abstract double CalculateRentalCost(int days);
}

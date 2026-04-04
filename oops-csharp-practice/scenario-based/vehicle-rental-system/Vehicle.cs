public abstract class Vehicle : IRentable
{
    protected string vehicleNumber;
    protected double rentPerDay;

    public Vehicle(string vehicleNumber, double rentPerDay)
    {
        this.vehicleNumber = vehicleNumber;
        this.rentPerDay = rentPerDay;
    }

    public abstract double CalculateRent(int days);
}

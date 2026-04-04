public class Bike : Vehicle
{
    public Bike(string vehicleNumber, double rentPerDay)
        : base(vehicleNumber, rentPerDay) { }

    public override double CalculateRent(int days)
    {
        return days * rentPerDay;
    }
}

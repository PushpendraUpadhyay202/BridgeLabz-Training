public class Truck : Vehicle
{
    public Truck(string vehicleNumber, double rentPerDay)
        : base(vehicleNumber, rentPerDay) { }

    public override double CalculateRent(int days)
    {
        return (days * rentPerDay) + (days * 200);
    }
}

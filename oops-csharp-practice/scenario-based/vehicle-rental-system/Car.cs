public class Car : Vehicle
{
    public Car(string vehicleNumber, double rentPerDay)
        : base(vehicleNumber, rentPerDay) { }

    public override double CalculateRent(int days)
    {
        return (days * rentPerDay) + 500;
    }
}

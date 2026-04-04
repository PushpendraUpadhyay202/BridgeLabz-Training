internal class Car : Vehicle, IGPS
{
    private string currentLocation = "Unknown";

    public Car(int vehicleId, string driverName, double ratePerKm, string regNo): base(vehicleId, driverName, ratePerKm, regNo) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }
}

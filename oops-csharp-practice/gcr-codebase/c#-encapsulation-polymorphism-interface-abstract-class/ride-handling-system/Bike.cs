internal class Bike : Vehicle, IGPS
{
    private string currentLocation = "Unknown";

    public Bike(int vehicleId, string driverName, double ratePerKm, string regNo): base(vehicleId, driverName, ratePerKm, regNo) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm * 0.8;
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

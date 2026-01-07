internal class Bike : Vehicle, IInsurable
{
    public Bike(string vehicleNumber, double rentalRate, string policyNumber): base(vehicleNumber, "Bike", rentalRate, policyNumber) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days * 0.9;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.05;
    }

    public string GetInsuranceDetails()
    {
        return "Bike Insurance (5%) | Policy No: " + GetInsurancePolicyNumber();
    }
}

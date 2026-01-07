internal class Truck : Vehicle, IInsurable
{
    public Truck(string vehicleNumber, double rentalRate, string policyNumber): base(vehicleNumber, "Truck", rentalRate, policyNumber) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days * 1.2;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.15;
    }

    public string GetInsuranceDetails()
    {
        return "Truck Insurance (15%) | Policy No: " + GetInsurancePolicyNumber();
    }
}

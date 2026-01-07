internal class Car : Vehicle, IInsurable
{
    public Car(string vehicleNumber, double rentalRate, string policyNumber): base(vehicleNumber, "Car", rentalRate, policyNumber) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.10;
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance (10%) | Policy No: " + GetInsurancePolicyNumber();
    }
}

internal class Clothing : Product, ITaxable
{
    public Clothing(int productId, string name, double price): base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.20;
    }

    public double CalculateTax()
    {
        return price * 0.12;
    }

    public string GetTaxDetails()
    {
        return "Clothing Tax: 12% GST";
    }
}

internal class Electronics : Product, ITaxable
{
    public Electronics(int productId, string name, double price): base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.10;
    }

    public double CalculateTax()
    {
        return price * 0.18;
    }

    public string GetTaxDetails()
    {
        return "Electronics Tax: 18% GST";
    }
}

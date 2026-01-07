internal class Groceries : Product
{
    public Groceries(int productId, string name, double price): base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return price * 0.05;
    }
}

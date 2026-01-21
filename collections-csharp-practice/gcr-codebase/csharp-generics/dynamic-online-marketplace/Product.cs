
class Product<TCategory> : ProductBase
    where TCategory : class
{
    public TCategory Category { get; }

    public Product(string name, double price, TCategory category)
        : base(name, price)
    {
        Category = category;
    }

    public override void Display()
    {
        System.Console.WriteLine(
            Name + " | ₹" + Price + " | Category: " +
            Category.GetType().Name);
    }
}


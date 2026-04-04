
public abstract class ProductBase
{
    public string Name { get; set; }
    public double Price { get; set; }

    protected ProductBase(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void Display();
}


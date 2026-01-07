using System;

internal abstract class Product
{
    protected int productId;
    protected string name;
    protected double price;

    protected Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    public int GetProductId()
    {
        return productId;
    }

    public string GetName()
    {
        return name;
    }

    public double GetPrice()
    {
        return price;
    }

    public void SetPrice(double price)
    {
        if (price > 0)
        {
            this.price = price;
        }
    }

    public abstract double CalculateDiscount();
}

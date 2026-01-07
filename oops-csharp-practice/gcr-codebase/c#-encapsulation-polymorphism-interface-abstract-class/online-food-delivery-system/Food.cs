using System;

internal abstract class FoodItem
{
    protected string itemName;
    protected double price;
    protected int quantity;

    protected FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetItemName()
    {
        return itemName;
    }

    public double GetPrice()
    {
        return price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public void GetItemDetails()
    {
        Console.WriteLine(
            $"Item: {itemName} | Price: {price} | Quantity: {quantity}");
    }

    public abstract double CalculateTotalPrice();
}

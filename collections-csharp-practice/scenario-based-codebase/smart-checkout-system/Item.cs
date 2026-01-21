class Item
{
    private string name;
    private int price;
    private int stock;

    public Item(string name, int price, int stock)
    {
        this.name = name;
        this.price = price;
        this.stock = stock;
    }

    public string GetName()
    {
        return name;
    }

    public int GetPrice()
    {
        return price;
    }

    public int GetStock()
    {
        return stock;
    }

    public void SetStock(int stock)
    {
        this.stock = stock;
    }

    public override string ToString()
    {
        return name + " Price: " + price + " Stock: " + stock;
    }
}

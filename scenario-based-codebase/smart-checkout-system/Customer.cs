using System.Collections.Generic;

class Customer
{
    private string name;
    private Dictionary<string, int> items;

    public Customer(string name)
    {
        this.name = name;
        items = new Dictionary<string, int>();
    }

    public void AddItem(string itemName, int quantity)
    {
        if (items.ContainsKey(itemName))
            items[itemName] = items[itemName] + quantity;
        else
            items.Add(itemName, quantity);
    }

    public string GetName()
    {
        return name;
    }

    public Dictionary<string, int> GetItems()
    {
        return items;
    }

    public override string ToString()
    {
        return name + " Items: " + items.Count;
    }
}

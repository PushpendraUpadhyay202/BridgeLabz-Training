using System;
using System.Collections.Generic;

class ShoppingCart
{
    static void Main(string[] args)
    {
        Dictionary<string, double> prices = new Dictionary<string, double>();
        List<string> order = new List<string>();

        AddItem(prices, order, "Apple", 30.0);
        AddItem(prices, order, "Banana", 10.0);
        AddItem(prices, order, "Milk", 50.0);

        Console.WriteLine("Items (Insertion Order):");
        foreach (string item in order)
            Console.WriteLine(item + " = " + prices[item]);

        Console.WriteLine("\nItems Sorted by Price:");
        SortedDictionary<double, List<string>> sorted = SortByPrice(prices);
        foreach (KeyValuePair<double, List<string>> entry in sorted)
            foreach (string item in entry.Value)
                Console.WriteLine(item + " = " + entry.Key);
    }

    static void AddItem(
        Dictionary<string, double> prices,
        List<string> order,
        string name,
        double price)
    {
        if (!prices.ContainsKey(name))
        {
            prices[name] = price;
            order.Add(name);
        }
    }

    static SortedDictionary<double, List<string>> SortByPrice(
        Dictionary<string, double> prices)
    {
        SortedDictionary<double, List<string>> sorted =
            new SortedDictionary<double, List<string>>();

        foreach (KeyValuePair<string, double> entry in prices)
        {
            if (!sorted.ContainsKey(entry.Value))
                sorted[entry.Value] = new List<string>();

            sorted[entry.Value].Add(entry.Key);
        }

        return sorted;
    }
}

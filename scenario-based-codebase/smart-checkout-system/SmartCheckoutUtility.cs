using System;
using System.Collections.Generic;

class SmartCheckoutUtility : ISmartCheckout
{
    private Queue<Customer> customers;
    private Dictionary<string, Item> items;

    public SmartCheckoutUtility()
    {
        customers = new Queue<Customer>();
        items = new Dictionary<string, Item>();

        items.Add("Milk", new Item("Milk", 40, 10));
        items.Add("Bread", new Item("Bread", 30, 15));
        items.Add("Eggs", new Item("Eggs", 6, 50));
    }

    public void AddCustomer()
    {
        Console.Write("Customer Name: ");
        string name = Console.ReadLine();

        Customer customer = new Customer(name);

        while (true)
        {
            Console.WriteLine("Available Items:");
            foreach (Item item in items.Values)
                Console.WriteLine(item);

            Console.Write("Item name (or done): ");
            string itemName = Console.ReadLine();

            if (itemName == "done")
                break;

            if (!items.ContainsKey(itemName))
                continue;

            Item storeItem = items[itemName];

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            if (storeItem.GetStock() < quantity)
            {
                Console.WriteLine("Not enough stock");
                continue;
            }

            storeItem.SetStock(storeItem.GetStock() - quantity);
            customer.AddItem(itemName, quantity);
        }

        customers.Enqueue(customer);
    }

    public void RemoveCustomer()
    {
        if (customers.Count == 0)
            return;

        Customer customer = customers.Dequeue();
        Dictionary<string, int> cart = customer.GetItems();

        foreach (string itemName in cart.Keys)
        {
            Item item = items[itemName];
            item.SetStock(item.GetStock() + cart[itemName]);
        }
    }

    public void ProcessNextCustomer()
    {
        if (customers.Count == 0)
            return;

        Customer customer = customers.Dequeue();
        int total = 0;

        Console.WriteLine("----- RECEIPT -----");
        Console.WriteLine("Customer: " + customer.GetName());

        Dictionary<string, int> cart = customer.GetItems();

        foreach (string itemName in cart.Keys)
        {
            Item storeItem = items[itemName];
            int quantity = cart[itemName];
            int price = storeItem.GetPrice();
            int subtotal = price * quantity;

            total += subtotal;
            Console.WriteLine(itemName + " x " + quantity + " = " + subtotal);
        }

        Console.WriteLine("-------------------");
        Console.WriteLine("Total: " + total);
        Console.WriteLine();
    }

    public void ShowQueue()
    {
        foreach (Customer customer in customers)
            Console.WriteLine(customer);
    }
}

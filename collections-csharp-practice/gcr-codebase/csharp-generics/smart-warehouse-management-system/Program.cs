using System;

class Program
{
    static void Main()
    {
        var electronicsStorage = new Storage<Electronics>();
        var groceriesStorage = new Storage<Groceries>();
        var furnitureStorage = new Storage<Furniture>();

        while (true)
        {
            Console.WriteLine("\n--- Smart Warehouse Menu ---");
            Console.WriteLine("1. Add Electronics");
            Console.WriteLine("2. Add Groceries");
            Console.WriteLine("3. Add Furniture");
            Console.WriteLine("4. Display All Items");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter electronics name: ");
                    electronicsStorage.AddItem(
                        new Electronics(Console.ReadLine()));
                    break;

                case 2:
                    Console.Write("Enter grocery name: ");
                    groceriesStorage.AddItem(
                        new Groceries(Console.ReadLine()));
                    break;

                case 3:
                    Console.Write("Enter furniture name: ");
                    furnitureStorage.AddItem(
                        new Furniture(Console.ReadLine()));
                    break;

                case 4:
                    Console.WriteLine("\n--- Electronics ---");
                    Utils.DisplayItems(electronicsStorage.GetAllItems());

                    Console.WriteLine("\n--- Groceries ---");
                    Utils.DisplayItems(groceriesStorage.GetAllItems());

                    Console.WriteLine("\n--- Furniture ---");
                    Utils.DisplayItems(furnitureStorage.GetAllItems());
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}


using System;

public class Menu
{
    private Utility utility = new Utility();

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Online Marketplace ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Add Clothing");
            Console.WriteLine("3. Apply Discount");
            Console.WriteLine("4. Display Products");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    utility.AddBook();
                    break;

                case 2:
                    utility.AddClothing();
                    break;

                case 3:
                    utility.ApplyDiscountToAll();
                    break;

                case 4:
                    utility.DisplayAll();
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}


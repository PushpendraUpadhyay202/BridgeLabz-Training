using System;

public class Utility
{
    private Catalog catalog = new Catalog();

    public void AddBook()
    {
        Console.Write("Book name: ");
        string name = Console.ReadLine();

        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        Product<BookCategory> book =
            new Product<BookCategory>(
                name,
                price,
                new BookCategory("General")
            );

        catalog.AddProduct(book);
    }

    public void AddClothing()
    {
        Console.Write("Clothing name: ");
        string name = Console.ReadLine();

        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        Product<ClothingCategory> clothing =
            new Product<ClothingCategory>(
                name,
                price,
                new ClothingCategory("M")
            );

        catalog.AddProduct(clothing);
    }

    public void ApplyDiscountToAll()
    {
        Console.Write("Enter discount percentage: ");
        double percentage = double.Parse(Console.ReadLine());

        foreach (ProductBase product in catalog.GetAllProducts())
        {
            ApplyDiscount(product, percentage);
        }

        Console.WriteLine("Discount applied.");
    }

    public void DisplayAll()
    {
        foreach (ProductBase product in catalog.GetAllProducts())
        {
            product.Display();
        }
    }

    // Generic method + constraint
    private void ApplyDiscount<T>(T product, double percentage)
        where T : ProductBase
    {
        product.Price -= product.Price * (percentage / 100);
    }
}


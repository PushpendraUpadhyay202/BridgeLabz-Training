using System;

internal class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Electronics(1, "Laptop", 60000),
            new Clothing(2, "Jacket", 3000),
            new Groceries(3, "Rice Bag", 1200)
        };

        CalculateFinalPrices(products);
    }

    static void CalculateFinalPrices(List<Product> products)
    {
        foreach (Product product in products)
        {
            double tax = 0;

            if (product is ITaxable taxableProduct)
            {
                tax = taxableProduct.CalculateTax();
                Console.WriteLine(taxableProduct.GetTaxDetails());
            }

            double discount = product.CalculateDiscount();
            double finalPrice = product.GetPrice() + tax - discount;

            Console.WriteLine($"Product: {product.GetName()} | Final Price: {finalPrice}");
        }
    }
}

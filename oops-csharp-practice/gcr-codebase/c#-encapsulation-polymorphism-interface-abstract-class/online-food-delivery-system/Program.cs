using System;

internal class Program
{
    static void Main(string[] args)
    {
        List<FoodItem> items = new List<FoodItem>
        {
            new VegItem("Paneer Butter Masala", 250, 2),
            new NonVegItem("Chicken Biryani", 300, 1)
        };

        ProcessFoodItems(items);
    }

    static void ProcessFoodItems(List<FoodItem> items)
    {
        foreach (FoodItem item in items)
        {
            item.GetItemDetails();

            double totalPrice = item.CalculateTotalPrice();
            double discount = 0;

            if (item is IDiscountable discountable)
            {
                discount = discountable.ApplyDiscount();
                Console.WriteLine(discountable.GetDiscountDetails());
            }

            double finalAmount = totalPrice - discount;

            Console.WriteLine($"Total Price: ₹{totalPrice}");
            Console.WriteLine($"Discount: ₹{discount}");
            Console.WriteLine($"Final Amount Payable: ₹{finalAmount}");
        }
    }
}

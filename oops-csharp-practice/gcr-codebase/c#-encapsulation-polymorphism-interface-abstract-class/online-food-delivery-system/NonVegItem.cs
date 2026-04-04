internal class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string itemName, double price, int quantity): base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        double basePrice = price * quantity;
        double extraCharge = basePrice * 0.15;
        return basePrice + extraCharge;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.05;
    }

    public string GetDiscountDetails()
    {
        return "Non-Veg Item Discount: 5%";
    }
}

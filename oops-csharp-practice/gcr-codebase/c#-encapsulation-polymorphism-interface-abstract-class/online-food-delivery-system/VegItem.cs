internal class VegItem : FoodItem, IDiscountable
{
    public VegItem(string itemName, double price, int quantity): base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return price * quantity;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.10;
    }

    public string GetDiscountDetails()
    {
        return "Veg Item Discount: 10%";
    }
}

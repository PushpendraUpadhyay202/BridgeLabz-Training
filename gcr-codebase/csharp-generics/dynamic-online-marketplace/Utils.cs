
public static class Utils
{
    public static void ApplyDiscount<T>(
        T product, double percentage) where T : ProductBase
    {
        product.Price -= product.Price * (percentage / 100);
    }
}


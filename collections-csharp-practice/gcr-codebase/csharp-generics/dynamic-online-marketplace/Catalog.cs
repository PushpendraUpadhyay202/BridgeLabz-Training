using System.Collections.Generic;

public class Catalog
{
    private List<ProductBase> products =
        new List<ProductBase>();

    public void AddProduct(ProductBase product)
    {
        products.Add(product);
    }

    public List<ProductBase> GetAllProducts()
    {
        return products;
    }
}


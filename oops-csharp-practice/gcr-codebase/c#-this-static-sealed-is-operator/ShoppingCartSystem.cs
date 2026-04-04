using System;

class Product{
    public static double discount = 10;

    public readonly int productID;
    public string productName;
    public double price;
    public int quantity;

    public Product(string productName, double price, int quantity, int productId){
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
        this.productID = productId;
    }

    public static void UpdateDiscount(double newDiscount){
        discount = newDiscount;
    }

    public void ProcessProduct(object obj){
        if (obj is Product){
	    Console.WriteLine("Product Name: " + productName);
	    Console.WriteLine("Price: " + price);
	    Console.WriteLine("Discount: " + discount + "% off");
        }
    }
}

class ShoppingCartSystem{
    static void Main(string[] args){
        Product p = new Product("Mouse", 500, 2, 301);
        p.ProcessProduct(p);
    }
}


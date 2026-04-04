using System;
class Product{
	private static int totalProducts = 0;

	private string productName;
	private double price;

	internal Product(string productName, double price){
		this.productName = productName;
		this.price = price;
		totalProducts++;
	}

	internal void DisplayProductDetails(){
		Console.WriteLine("\nHere are the product details: ");
		Console.WriteLine("Product Name: " + productName);
		Console.WriteLine("Product: " + price);
	}

	internal static void DisplayTotalProducts(){
		Console.WriteLine("\nTotal Number of products created so far: " + totalProducts);
	}
}

class ProductInventory{
	static void Main(String[] args){
		Product product1 = new Product("HP Laptop", 25000);
		Product product2 = new Product("Dell Laptop", 30000);

		product1.DisplayProductDetails();
		product2.DisplayProductDetails();

		Product.DisplayTotalProducts();
	}
}

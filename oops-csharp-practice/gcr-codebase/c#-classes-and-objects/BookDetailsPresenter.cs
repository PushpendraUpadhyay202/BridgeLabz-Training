using System;
public class Book{
	private string title;
	private string author;
	private double price;

	public Book(string title, string author, double price){
		this.title = title;
		this.author = author;
		this.price = price;
	}

	public void DisplayDetails(){
		Console.WriteLine("\nFollowing are the details of the book:\n");		
		Console.WriteLine("Title: " + this.title);
		Console.WriteLine("Author: " + this.author);
		Console.WriteLine("Price: " + this.price);
		Console.WriteLine();
	}
}

public class BookDetailsPresenter{
	public static void Main(string[] args){
		// Creating book class instance
		Book book1 = new Book("Atomic Habits", "James Clear", 189);
		Book book2 = new Book("IKIGAI", "Hector Garcia", 169);

		// Displaying books details
		book1.DisplayDetails();
		book2.DisplayDetails();
	}
}

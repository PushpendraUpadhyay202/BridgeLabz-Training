using System;
class Book{
	private string title;
	private string author;
	private double price;

	// Default constructors
	internal Book(){
		// Setting default values
		this.title = "Default Title";
		this.author = "Default Author";
		this.price = 10.00;
	}

	// Parameterized construtors
	internal Book(string title, string author, double price){
		this.title = title;
		this.author = author;
		this.price = price;
	}
	
	// Method to display book details
	internal void DisplayBookDetails(){
		Console.WriteLine("Book Name: " + this.title);
		Console.WriteLine("Book Author Name: " + this.author);
		Console.WriteLine("Book Price: " + this.price);
	}

	static void Main(string[] args){
		// Creating a book with default values
		Book defaultBook = new Book();
		// Creating a book with non-default values
		Book nonDefaultBook = new Book("Non Default Title", "Non Default Author", 120.00);

		defaultBook.DisplayBookDetails();
		nonDefaultBook.DisplayBookDetails();
	}
}

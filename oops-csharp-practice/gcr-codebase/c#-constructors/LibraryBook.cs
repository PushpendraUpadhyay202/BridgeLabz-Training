using System;
class LibraryBook{
	// Static Attribute
	private static long serialNumberCounter = 0; 
	// Attributes
	private string title;
	private string author;
	private double price;
	private bool availability; // True if available and false otherwise
	private long serialNumber;

	// Parameterized Constructor
	internal LibraryBook(string title, string author, double price){
		this.title = title;
		this.author = author;
		this.price = price;
		this.availability = true;
		this.serialNumber = ++serialNumberCounter;
	}

	// Borrow Book method
	internal void BorrowBook(){
		if(this.availability){
			this.availability = false;
			Console.WriteLine("Book Borrowed");
		}
		else{
			Console.WriteLine("Book not available");
		}
		
	}

	static void Main(string[] args){
		LibraryBook book1 = new LibraryBook("book1", "author1", 129);
		LibraryBook book2 = new LibraryBook("book2", "author2", 130);
		
		book1.BorrowBook();
		book2.BorrowBook();
		book1.BorrowBook();
	}
}

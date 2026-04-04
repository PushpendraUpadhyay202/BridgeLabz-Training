using System;

class Book{
    public static string libraryName = "Central Library";

    public readonly string ISBN;
    public string title;
    public string author;

    public Book(string title, string author, string isbn){
        this.title = title;
        this.author = author;
        this.ISBN = isbn;
    }

    public static void DisplayLibraryName(){
        Console.WriteLine(libraryName);
    }

    public void ShowBook(object obj){
        if (obj is Book){
            Console.WriteLine(title + " by " + author + " | ISBN: " + ISBN);
        }
    }
}

class LibraryManagementSystem{
    static void Main(){
        Book b = new Book("Clean Code", "Robert Martin", "ISBN123");
        b.ShowBook(b);
        Book.DisplayLibraryName();
    }
}


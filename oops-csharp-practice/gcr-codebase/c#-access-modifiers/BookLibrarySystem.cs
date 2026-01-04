using System;

class Book{
    public string ISBN;
    protected string title;
    private string author;

    internal Book(string ISBN, string title, string author){
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    public string GetAuthor(){
        return author;
    }

    public void SetAuthor(string author){
        this.author = author;
        Console.WriteLine("\nAuthor Updated");
    }

    internal void DisplayBookDetails(){
        Console.WriteLine("\nGiven below are the book details:");
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
}

class EBook : Book{
    private float fileSize;

    internal EBook(string ISBN, string title, string author, float fileSize): base(ISBN, title, author){
        this.fileSize = fileSize;
    }

    internal void DisplayEBookDetails(){
        Console.WriteLine("\nGiven below are the eBook details:");
        Console.WriteLine("ISBN: " + ISBN);      // public → accessible
        Console.WriteLine("Title: " + title);    // protected → accessible
        Console.WriteLine("File Size: " + fileSize + " MB");
    }
}

class BookLibrarySystem{
    static void Main(string[] args){
        Book book1 = new Book("978-0131103627", "C Programming Language", "Dennis Ritchie");
        EBook ebook1 = new EBook("978-0201633610", "Design Patterns", "Erich Gamma", 5.6f);

        book1.DisplayBookDetails();
        ebook1.DisplayEBookDetails();

        book1.SetAuthor("D. M. Ritchie");
        Console.WriteLine("\nAuthor: " + book1.GetAuthor());
    }
}


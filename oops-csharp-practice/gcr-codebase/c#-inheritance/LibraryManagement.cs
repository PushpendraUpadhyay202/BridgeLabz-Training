using System;

class Book{
    protected string title;
    protected int publicationYear;

    public Book(string title, int publicationYear){
        this.title = title;
        this.publicationYear = publicationYear;
    }

    public virtual void DisplayInfo(){
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Publication Year: " + publicationYear);
    }
}

class Author : Book{
    private string name;
    private string bio;

    public Author(string title, int publicationYear, string name, string bio): base(title, publicationYear){
        this.name = name;
        this.bio = bio;
    }

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Author Name: " + name);
        Console.WriteLine("Author Bio: " + bio);
    }
}

class LibraryManagement{
    static void Main(string[] args){
        Author bookWithAuthor = new Author("Clean Code", 2008, "Robert C. Martin", "Software engineer and author known for Clean Code principles.");
        bookWithAuthor.DisplayInfo();
    }
}

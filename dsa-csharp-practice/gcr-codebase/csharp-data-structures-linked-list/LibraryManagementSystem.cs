using System;

class BookNode
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookId;
    public bool IsAvailable;

    public BookNode Prev;
    public BookNode Next;

    public BookNode(int id, string title, string author, string genre, bool available)
    {
        BookId = id;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = available;
        Prev = null;
        Next = null;
    }
}

class DoublyLinkedLibrary
{
    private BookNode head;
    private BookNode tail;
    private int count;

    public DoublyLinkedLibrary()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void AddAtBeginning(BookNode newBook)
    {
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        count++;
    }

    public void AddAtEnd(BookNode newBook)
    {
        if (tail == null)
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        count++;
    }

    public void AddAtPosition(BookNode newBook, int position)
    {
        if (position <= 1)
        {
            AddAtBeginning(newBook);
            return;
        }

        if (position > count)
        {
            AddAtEnd(newBook);
            return;
        }

        BookNode temp = head;
        for (int i = 1; i < position - 1; i++)
        {
            temp = temp.Next;
        }

        newBook.Next = temp.Next;
        newBook.Prev = temp;
        temp.Next.Prev = newBook;
        temp.Next = newBook;

        count++;
    }

    public void RemoveById(int bookId)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == bookId)
            {
                if (temp == head)
                    head = temp.Next;

                if (temp == tail)
                    tail = temp.Prev;

                if (temp.Prev != null)
                    temp.Prev.Next = temp.Next;

                if (temp.Next != null)
                    temp.Next.Prev = temp.Prev;

                count--;
                Console.WriteLine("Book removed successfully.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found.");
    }

    public void Search(string keyword)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Title.Equals(keyword, StringComparison.OrdinalIgnoreCase) ||
                temp.Author.Equals(keyword, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No matching book found.");
    }

    public void UpdateAvailability(int bookId, bool status)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == bookId)
            {
                temp.IsAvailable = status;
                Console.WriteLine("Availability updated.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found.");
    }

    public void DisplayForward()
    {
        BookNode temp = head;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Next;
        }
    }

    public void DisplayReverse()
    {
        BookNode temp = tail;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Prev;
        }
    }

    public int CountBooks()
    {
        return count;
    }

    private void DisplayBook(BookNode book)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("ID: " + book.BookId);
        Console.WriteLine("Title: " + book.Title);
        Console.WriteLine("Author: " + book.Author);
        Console.WriteLine("Genre: " + book.Genre);
        Console.WriteLine("Available: " + (book.IsAvailable ? "Yes" : "No"));
    }
}

class LibraryManagementSystem{
    static void Main(string[] args)
    {
        DoublyLinkedLibrary library = new DoublyLinkedLibrary();

        library.AddAtEnd(new BookNode(1, "1984", "George Orwell", "Dystopian", true));
        library.AddAtBeginning(new BookNode(2, "Clean Code", "Robert Martin", "Programming", true));
        library.AddAtPosition(new BookNode(3, "The Alchemist", "Paulo Coelho", "Fiction", false), 2);

        Console.WriteLine("All Books Forward");
        library.DisplayForward();

        Console.WriteLine("All Books Reverse");
        library.DisplayReverse();

        Console.WriteLine("Search Result");
        library.Search("George Orwell");

        library.UpdateAvailability(3, true);

        library.RemoveById(1);

        Console.WriteLine("Total Books: " + library.CountBooks());
    }
}


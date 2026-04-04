using System;

class LibraryManagement
{
    static string[] titles = {
    "The God of Small Things",
    "Midnight's Children",
    "Wings of Fire",
    "The White Tiger",
    "Malgudi Days",
    "Train to Pakistan",
    "Discovery of India",
    "Five Point Someone",
    "Gitanjali",
    "A Suitable Boy"
};

static string[] authors = {
    "Arundhati Roy",
    "Salman Rushdie",
    "A. P. J. Abdul Kalam",
    "Aravind Adiga",
    "R. K. Narayan",
    "Khushwant Singh",
    "Jawaharlal Nehru",
    "Chetan Bhagat",
    "Rabindranath Tagore",
    "Vikram Seth"
};


    static bool[] isAvailable = new bool[titles.Length];
    static LibraryManagement()
    {
        Console.WriteLine("\n============Application Started=================>");
        for(int i=0;i<isAvailable.Length;i++)isAvailable[i] = true;

    }

    static void Main()
    {
        int choice;

        while(true)
        {
            Console.WriteLine("\n📚 Library Management System\n1. Display All Books\n2. Search Book by Title\n3. Checkout Book\n4. Return Book\n5. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayBooks();
                    break;
                case 2:
                    SearchBook();
                    break;
                case 3:
                    CheckoutBook();
                    break;
                case 4:
                    ReturnBook();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using the Library System!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    return;
            }

        }
    }

    // ===============================================Display all books================>
    static void DisplayBooks()
    {
        Console.WriteLine("\nAvailable Books:\n");

        for (int i = 0; i < titles.Length; i++)
        {
            string status = isAvailable[i] ? "Available" : "Checked Out";
            Console.WriteLine((i + 1) + ". " + titles[i] + " by " + authors[i] + " - " + status);
        }
    }

    //============================================ Search book by partial title=================>
    static void SearchBook()
    {
        Console.Write("\nEnter part of book title to search: ");
        string search = Console.ReadLine().ToLower();
        bool found = false;

        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i].ToLower().Contains(search))
            {
                string status = isAvailable[i] ? "Available" : "Checked Out";
                Console.WriteLine((i + 1) + ". " + titles[i] + " by " + authors[i] + " - " + status);
                found = true;
            }
        }

        if (!found)Console.WriteLine("No books found with that title.");
    }

    //============================================= Checkout book=============================>
    static void CheckoutBook()
    {
        Console.Write("\nEnter book number to checkout: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < titles.Length)
        {
            if (isAvailable[index])
            {
                isAvailable[index] = false;
                Console.WriteLine("'" + titles[index] + "' has been checked out successfully.");
            }
            else Console.WriteLine("Book is already checked out.");
        }
        else Console.WriteLine("Invalid book number.");
    }

    //======================================================= Return book========================>
    static void ReturnBook()
    {
        Console.Write("\nEnter book number to return: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < titles.Length)
        {
            if (!isAvailable[index])
            {
                isAvailable[index] = true;
                Console.WriteLine("'" + titles[index] + "' has been returned successfully.");
            }
            else Console.WriteLine("Book is already available.");
        }
        else Console.WriteLine("Invalid book number.");
    }
}
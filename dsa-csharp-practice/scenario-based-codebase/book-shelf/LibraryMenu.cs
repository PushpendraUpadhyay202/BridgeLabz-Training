using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Shelf
{
    internal class LibraryMenu
    {
        private ILibraryService service;

        public LibraryMenu(ILibraryService service)
        {
            this.service = service;
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display Books by Genre");
                Console.WriteLine("4. Display All Books");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBookUI();
                        break;
                    case 2:
                        Console.Write("Enter ISBN: ");
                        service.RemoveBook(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Enter Genre: ");
                        service.DisplayByGenre(Console.ReadLine());
                        break;
                    case 4:
                        service.DisplayAllBooks();
                        break;
                }
            } while (choice != 5);
        }

        private void AddBookUI()
        {
            Book book = new Book();

            Console.Write("ISBN: ");
            book.ISBN = Console.ReadLine();

            Console.Write("Title: ");
            book.Title = Console.ReadLine();

            Console.Write("Author: ");
            book.Author = Console.ReadLine();

            Console.Write("Genre: ");
            book.Genre = Console.ReadLine();

            service.AddBook(book);
        }
    }
}

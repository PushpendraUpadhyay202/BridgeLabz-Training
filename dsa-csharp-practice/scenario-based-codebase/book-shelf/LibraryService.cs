using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Shelf
{
    internal class LibraryService : ILibraryService
    {
        private string[] genres = new string[10];
        private Node[] lists = new Node[10];
        private int genreCount = 0;

        public void AddBook(Book book)
        {
            int index = FindGenreIndex(book.Genre);

            // New Genre
            if (index == -1)
            {
                genres[genreCount] = book.Genre;
                lists[genreCount] = new Node(book);
                genreCount++;
            }
            else
            {
                // Avoid duplicate ISBN
                if (IsDuplicate(lists[index], book.ISBN))
                {
                    Console.WriteLine("Duplicate book not allowed.");
                    return;
                }

                Node newNode = new Node(book);
                newNode.next = lists[index];
                lists[index] = newNode;
            }

            Console.WriteLine("Book added successfully.");
        }

        public void RemoveBook(string isbn)
        {
            for (int i = 0; i < genreCount; i++)
            {
                Node current = lists[i];
                Node prev = null;

                while (current != null)
                {
                    if (current.data.ISBN == isbn)
                    {
                        if (prev == null)
                            lists[i] = current.next;
                        else
                            prev.next = current.next;

                        Console.WriteLine("Book removed successfully.");
                        return;
                    }

                    prev = current;
                    current = current.next;
                }
            }

            Console.WriteLine("Book not found.");
        }

        public void DisplayByGenre(string genre)
        {
            int index = FindGenreIndex(genre);

            if (index == -1)
            {
                Console.WriteLine("Genre not found.");
                return;
            }

            Node temp = lists[index];
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public void DisplayAllBooks()
        {
            for (int i = 0; i < genreCount; i++)
            {
                Console.WriteLine("\nGenre: " + genres[i]);
                Node temp = lists[i];
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }

        private int FindGenreIndex(string genre)
        {
            for (int i = 0; i < genreCount; i++)
            {
                if (genres[i] == genre)
                    return i;
            }
            return -1;
        }

        private bool IsDuplicate(Node head, string isbn)
        {
            while (head != null)
            {
                if (head.data.ISBN == isbn)
                    return true;
                head = head.next;
            }
            return false;
        }
    }
}

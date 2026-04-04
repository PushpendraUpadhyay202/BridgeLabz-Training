using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Shelf
{
    internal interface ILibraryService
    {
        void AddBook(Book book);
        void RemoveBook(string isbn);
        void DisplayByGenre(string genre);
        void DisplayAllBooks();
    }
}

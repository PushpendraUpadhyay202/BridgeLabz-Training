using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Shelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILibraryService service = new LibraryService();
            LibraryMenu menu = new LibraryMenu(service);
            menu.ShowMenu();
        }
    }
}

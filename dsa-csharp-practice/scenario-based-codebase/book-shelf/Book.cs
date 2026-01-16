using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Shelf
{
    internal class Book
    {
        private string isbn;
        private string title;
        private string author;
        private string genre;

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public override string ToString()
        {
            return "ISBN: " + isbn +
                   ", Title: " + title +
                   ", Author: " + author +
                   ", Genre: " + genre;
        }
    }
}
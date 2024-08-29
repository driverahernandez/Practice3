using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public long Isbn { get; private set; }
        public bool IsCheckedOut { get; set; }

        public Book(string title, string author, long isbn)
        {
            this.Title = title;
            this.Author = author;
            this.Isbn = isbn;
        }

        public void displayDetails()
        {
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("ISBN: " + Isbn);
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public long Isbn { get;  }
        public bool IsCheckedOut { get; set; }

        public Book(string title, string author, long isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }

        public void displayDetails()
        {
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("ISBN: " + Isbn);
            
        }

    }
}

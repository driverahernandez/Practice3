using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class Library
    {
        private List<Book> Books;
        public Library()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book) => Books.Add(book);

        // remove by title
        public void RemoveBook(string title){
            foreach (var book in Books)
            {
                if (book.Title == title)
                {
                    Books.Remove(book);
                    return;
                }
            }
                throw new BookNotFoundException("Book with given title was not found.");
        }

        //remove by isbn
        public void RemoveBook(long isbn)
        {
            
            foreach (var book in Books)
            {
                if (book.Isbn == isbn)
                {
                    Books.Remove(book);
                    return;
                }
            }
            
            throw new BookNotFoundException("Book with given ISBN was not found.");
        }
        public void displayBooksList()
        {
            if (Books.Count > 0)
            {
                Console.WriteLine("****All books****"); 
                foreach (var book in Books)
                {
                    book.displayDetails();
                    Console.WriteLine();
                }

            }
            else
                Console.WriteLine("No books in the library.");
        }

        public void checkOutBook(long isbn)
        {
            foreach (var book in Books)
            {
                if (book.Isbn == isbn)
                {
                    if (!book.IsCheckedOut)
                    {
                        book.IsCheckedOut = true;
                        return;
                    }
                    else
                        throw new BookAlreadyCheckedOutException("Book is already checked out.");
                }
            }
            throw new BookNotFoundException("Book with given ISBN was not found.");
        }

        public void returnBook(long isbn)
        {
            foreach (var book in Books)
            {
                if (book.Isbn == isbn)
                {
                    if(book.IsCheckedOut)
                    {
                    book.IsCheckedOut = false;
                    return;
                    }
                    else
                        throw new BookNotCheckedOutException("Book is not checked out.");
                }
            }
            throw new BookNotFoundException("Book with given ISBN was not found.");
        }

    }
}

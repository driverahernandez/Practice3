using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var library = new Library();

            var dracula = new Book("Dracula", "B. Stoker", 9798721052927);
            var frankenstein = new Book("Frankenstein", "M. Shelley", 9780143131847);
            var dorianGray = new Book("Picture of Dorian Gray", "O. Wilde", 9780141439570);

            library.AddBook(dracula);
            library.AddBook(frankenstein);
            library.AddBook(dorianGray);
            

            var validIsbn = dracula.Isbn;
            var invalidIsbn = 9798721052928;


            // REMOVING A BOOK
            Console.WriteLine("Valid attempt, when ISBN does exist:");
            try
            {
                
                library.RemoveBook(validIsbn);
                Console.WriteLine("Book was removed successfully.");
                Console.WriteLine();
            }
            catch(BookNotFoundException ex) 
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine();
            }
            
            Console.WriteLine("Invalid attempt, when ISBN does not exist:");
            try
            {
                library.RemoveBook(invalidIsbn);
                Console.WriteLine("Book was removed successfully."); //won't be executed
                Console.WriteLine();

            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine();
            }

            // CHECKING OUT A BOOK
            Console.WriteLine("Valid attempt, when book has not been checked out yet:");
            try
            {
                library.checkOutBook(frankenstein.Isbn);
                Console.WriteLine("Book was checked out successfully.");
                Console.WriteLine();
            }
            catch (BookAlreadyCheckedOutException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine();
            }

            Console.WriteLine("Invalid attempt, when book has been checked out already:");
            try
            {
                library.checkOutBook(frankenstein.Isbn);
                Console.WriteLine("Book was checked out successfully."); //won't be executed
                Console.WriteLine();
            }
            catch (BookAlreadyCheckedOutException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine();
            }

            // RETURNING A BOOK 
            Console.WriteLine("Valid attempt, when book has been checked out already:");
            try
            {
                library.returnBook(frankenstein.Isbn);
                Console.WriteLine("Book was returned successfully.");
                Console.WriteLine();
            }
            catch (BookAlreadyCheckedOutException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine();
            }

            Console.WriteLine("Invalid attempt, when book has not been checked out yet:");
            try
            {
                library.returnBook(frankenstein.Isbn);
                Console.WriteLine("Book was returned successfully."); //won't be executed
                Console.WriteLine();
            }
            catch (BookNotCheckedOutException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine();
            }
        }
    }
}
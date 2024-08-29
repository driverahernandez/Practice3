using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException() { }
        public BookNotFoundException(string message) : base(message) { }
    }
    public class BookAlreadyCheckedOutException : Exception
    {
        public BookAlreadyCheckedOutException() { }
        public BookAlreadyCheckedOutException(string message) : base(message) { }
    }
    public class BookNotCheckedOutException : Exception
    {
        public BookNotCheckedOutException() { }
        public BookNotCheckedOutException(string message) : base(message) { }
    }
}

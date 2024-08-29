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
        public BookNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
    public class BookAlreadyCheckedOutException : Exception
    {
        public BookAlreadyCheckedOutException() { }
        public BookAlreadyCheckedOutException(string message) : base(message) { }
        public BookAlreadyCheckedOutException(string message, Exception innerException) : base(message, innerException) { }
    }
    public class BookNotCheckedOutException : Exception
    {
        public BookNotCheckedOutException() { }
        public BookNotCheckedOutException(string message) : base(message) { }
        public BookNotCheckedOutException(string message, Exception innerException) : base(message, innerException) { }
    }
}

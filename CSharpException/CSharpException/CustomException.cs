using System;
namespace CSharpException
{
    public class InvalidSideException : Exception
    {
        public double value;

        public InvalidSideException() { }

        public InvalidSideException(string message) : base(message) { }

        public InvalidSideException(string message, Exception innerException) : base(message, innerException) { }

        public InvalidSideException(string message, double myvalue) { value = myvalue; }
    }

    public class InvalidTriangleExeption : Exception
    {
        public InvalidTriangleExeption() { }

        public InvalidTriangleExeption(string message) : base(message) { }
    }
}


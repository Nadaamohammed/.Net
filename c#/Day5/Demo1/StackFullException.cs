using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class StackFullException : Exception
    {
        public StackFullException() : base("Stack is full") // Default constructor with a message
        {
        }
        public StackFullException(string message) : base(message) // Constructor with a custom message
        {
        }
        public StackFullException(string message, Exception inner) : base(message, inner) // Constructor with a custom message and inner exception
        {
        }
    }
}

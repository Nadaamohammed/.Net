using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class StackEmptyException : Exception
    {
        public StackEmptyException() : base("stack is empty") { }
        public StackEmptyException(string message) : base(message) // Constructor with a custom message
        {
        }
    }
}

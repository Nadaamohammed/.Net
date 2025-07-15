using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    internal struct Fib : ISeries
    {
        int current = 1;
        int previous = 0, next = 1, temp;

        public Fib(int start)
        {
            current = start; // Initialize the current position in the Fibonacci series
            previous = 0; // First number in Fibonacci series
            next = 1; // Second number in Fibonacci series
        }
        public int GetNextNumber()
        {
            // Fibonacci series logic
            if (current == 1)
            {
                current++;
                return 0; // First number in Fibonacci series
            }
            else if (current == 2)
            {
                current++;
                return 1; // Second number in Fibonacci series
            }
            else
            {
                
                for (int i = 3; i <= current; i++)
                {
                    temp = next;
                    next += previous;
                    previous = temp;
                }
                current++;
                return next; // Return the next Fibonacci number
            }
        }
    }
}

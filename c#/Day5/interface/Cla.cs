using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    internal class Cla : ISeries
    {
        public int GetNextNumber()
        {
            // Implementing the method from ISeries interface
            // For demonstration, let's return a constant value
            return 0; // This can be any logic you want to implement
        }

        // You can add more methods or properties specific to Cla if needed
    }
}

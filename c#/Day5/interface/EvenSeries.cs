using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    internal class EvenSeries : ISeries
    {
        int current = 0;
        public int GetNextNumber()
        {
            int i = current;
            current += 2; // Increment current by 2 to get the next even number
            return i;
        }
    }
}

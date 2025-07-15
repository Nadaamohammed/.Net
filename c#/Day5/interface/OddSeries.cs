using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  interfacee
{
    class OddSeriescs : ISeries
    {
        int current=1;
        public int GetNextNumber()
        {
            int i = current;
            current += 2; // Increment current by 2 to get the next odd number
            return i;
        }
    }
}

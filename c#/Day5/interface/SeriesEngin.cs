using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    internal class SeriesEngin
    {
        public void PrintNextNumber(ISeries series)
        {
            if (series == null)
            {
                throw new ArgumentNullException(nameof(series), "Series cannot be null");
            }
            int nextNumber = series.GetNextNumber();
            Console.WriteLine($"Next number in the series: {nextNumber}");
        }
    }
}

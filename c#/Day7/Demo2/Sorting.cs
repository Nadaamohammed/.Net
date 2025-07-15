using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Demo2
{
    //publisher
    //public event  Func<int, int, bool> c;
    internal class Sorting
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // Generic Sort with comparator
        public static void Sort<T>(T[] arr, Func<T, T, bool> compare)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (compare(arr[j], arr[j + 1]))
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }

    
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Sorting
    {
        public static void swap<t>(t a, t b)
        {
            t temp = a;
            a = b;
            b = temp;

        }

        public static void Sort(int[] arr , del m)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (m.Invoke(arr[j] , arr[j+1]))
                        swap(arr[j], arr[j+1]);
                }
            }
        }
    }
}
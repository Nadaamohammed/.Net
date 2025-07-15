using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dempo1
{
    internal  static class MyMath
    {
        //extension method
        public static int Add(this int a, int b)
        {
            return a + b;
        }
        public static int mirror(this int a)
        {
            a.ToString().Split("").Reverse();
            return a;
        }
    }
}

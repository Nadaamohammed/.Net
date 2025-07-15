using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    struct Complex
    {
        /*int real;
        int imaginary;
        public int Real
        {
            get { return real; }
            set { real = value; }
        }
        public int Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }*/
        //automatic properties , not use if we have constrains
        public int Real { get; set; } = 0;
        public int Imaginary { get; set; } = 20;
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}

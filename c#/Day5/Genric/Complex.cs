using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    internal struct Complex : IComparable , ICloneable
    {
        public int CompareTo(object? obj)
        {
            //as use with reference data
            Complex o = (Complex)obj;
            //if(Real > o.Real)
            //{
            //    return 1; //this is greater than o
            //}
            //else if (Real < o.Real)
            //{
            //    return -1; //this is less than o
            //}
            //else
            //{
            //    if (Imaginary > o.Imaginary)
            //    {
            //        return 1; //this is greater than o
            //    }
            //    else if (Imaginary < o.Imaginary)
            //    {
            //        return -1; //this is less than o
            //    }
            //    else
            //    {
            //        return 0; //equal
            //    }
           // }
           return Real.CompareTo(o.Real) != 0 ? Real.CompareTo(o.Real) : Imaginary.CompareTo(o.Imaginary);
            //return Real.CompareTo(o.Real) == 0 ? Imaginary.CompareTo(o.Imaginary) : Real.CompareTo(o.Real);


        }

        public int Real { get; set; }
        public int Imaginary { get; set; }
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(
                c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                c1.Real * c2.Imaginary + c1.Imaginary * c2.Real
            );
        }
    }
}

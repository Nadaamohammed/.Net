using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    internal class Coplex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public Coplex(int _real=0 , int _img=0)
        {
            Real = 0;
            Img = 0;
            //Real = _real;
            //Img = _img;
        }
        public override string ToString()
        {
            if (Img < 0)
            {
                return $"{Real} - {-Img}i";
            }
            else
            {
                return $"{Real} + {Img}i";
            }
        }
        // Overloading the + operator
        public static Coplex operator +(Coplex c1, Coplex c2)
        {
            return new Coplex(c1.Real + c2.Real, c1.Img + c2.Img);
        }

        public static bool operator ==(Coplex c1, Coplex c2)
        {
            if (ReferenceEquals(c1, c2)) return true; // Check if both references point to the same object
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null)) return false; // Check for null references
            return c1.Real == c2.Real && c1.Img == c2.Img; // Compare values
        }
        public static bool operator !=(Coplex c1, Coplex c2)
        {
            if (ReferenceEquals(c1, c2)) return false; // Check if both references point to the same object
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null)) return true; // Check for null references
            return c1.Real == c2.Real && c1.Img == c2.Img; // Compare values
        }

        public static Coplex operator ++(Coplex c1)
        {
            return new Coplex(c1.Real + 1, c1.Img);
        }
    }
}

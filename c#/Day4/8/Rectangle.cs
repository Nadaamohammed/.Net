using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    //inheritance only from 1 class
    //can't inherit from this class
    sealed class Rectangle : Shape
    {
        public Rectangle(int _dim1 = 1, int _dim2 = 1) :base(_dim1, _dim2) 
        {
            
        }
        public override float Area()
        {
            return Dim1 * Dim2;
        }
        public override string ToString()
        {
            return $"Rectangle with dimensions {Dim1} and {Dim2}, Area: {Area()}";
        }

        //class Abc : Rectangle
        //{
        //    // This class cannot inherit from Rectangle because Rectangle is not sealed.
        //    // If Rectangle were sealed, this would cause a compile-time error.
        //}

        public override bool Equals(object? obj)
        {
            //Rectangle r = (Rectangle)obj;
            Rectangle r = obj as Rectangle;
            if (r == null)
            {
                return false;
            }
            if (r.Dim1 != Dim1 || r.Dim2 != Dim2)
            {
                return false;
            }
            else
            {
                return true;
            }
            //return base.Equals(obj);
        }
    }
}

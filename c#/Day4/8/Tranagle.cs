using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
     internal class Tranagle : Shape
    {
        public Tranagle(int _dim1 = 0, int _dim2 = 0) : base(_dim1, _dim2)
        {
        }
        //public new:virtual float Area()
        public override float Area()
        {
            return 0.5f * Dim1 * Dim2; // Area of triangle = 0.5 * base * height
        }
        public sealed override string ToString()
        {
            return $"Triangle with dimensions {Dim1} and {Dim2}, Area: {Area()}";
        }
        public override bool Equals(object? obj)
        {
            if(obj == null ) return false;
            if(this.GetType() != obj.GetType()) return false;
            Tranagle t = obj as Tranagle;
            if (t == null)
            {
                return false;
            }
            if (t.Dim1 != Dim1 || t.Dim2 != Dim2)
            {
                return false;
            }
            else
            {
                return true;
            }
            //return base.Equals(obj);
        }

        class Abc : Tranagle
        {
            // This class cannot inherit from Tranagle because Tranagle is not sealed.
            // If Tranagle were sealed, this would cause a compile-time error.
        }
    }
}

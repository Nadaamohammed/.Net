﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    //can't create an object 
    abstract class Shape2
    {
        protected int dim1;
        protected int dim2;
        public Shape2(int _dim1 = 0, int _dim2 = 0)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }
        public int Dim1
        {
            get { return dim1; }
            set { dim1 = value; }
        }
        public int Dim2
        {
            get { return dim2; }
            set { dim2 = value; }
        }
        public Shape2()
        {
            dim1 = 1;
            dim2 = 1;

        }
        public Shape2(int _dim1)
        {
            dim1 = _dim1;
            dim2 = 1;
        }
        public virtual float Area()
        {
            return 0;
        }
        public void print()
        {
            Console.WriteLine($"{dim1}:{dim2}");
        }
        public override string ToString()
        {
            return $"Shape with dimensions {dim1} and {dim2}";

        }

        // Abstract method to be implemented by derived classes
        public abstract string GetShapeType();

        public static implicit operator Shape2(Rectangle v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Shape2(Tranagle v)
        {
            throw new NotImplementedException();
        }
    }
}
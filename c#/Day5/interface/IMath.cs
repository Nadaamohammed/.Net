using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacee
{
    interface ID
    {
        int divide(int a, int b)
        {
            return a / b;
        }
    }
    interface IM
    {
        int divide(int a, int b)
        {
            return a / b;
        }
    }
    //cann't implement instance members in an interface
    internal interface IMath
    {
        public int add(int a, int b);
        public int sub(int a, int b);
        public int mul(int a, int b);
        public int div(int a, int b);

    }
    class math : IMath , ID, IM
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
        // Implementing the methods from ID and IM interfaces
        //explicit interface implementation
        int ID.divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
         int IM.divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }

       
    }
}

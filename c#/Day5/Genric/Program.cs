using System.Numerics;

namespace Genric
{
    internal class Program
    {
        public static void swap<t>(ref t a, ref t b) where t :class ,IComparable  //ICloneable
        {
            //use in generic method

            //1- gethashcode
            //2- to string
            //3- equals
            //4-gettype

            t z;//5-define a temporary variable of type t
            z.CompareTo(a);
            z = a;  //6- equal operator
            //z=0; , z=null; // Initialize to default value of type t
            z = default; //7- default operator
            object o = z; //8- cast operator (boxing) 
            z = (t)o;//9- unbox operator
            t temp = a; 
            a = b;
            b = temp;
        }
        public static void Main(string[] args)
        {
            float a = 10.5f, b = 20.5f;
            swap(ref a, ref b); // Swap two float values

            int x = 10, y = 20;
            swap(ref x, ref y); // Swap two int values

            string str1 = "Hello", str2 = "World";
            swap(ref str1, ref str2); // Swap two string values

            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(5, 6);
            swap(ref c1, ref c2); // Swap two Complex numbers

            Stack<Complex> stack = new Stack<Complex>();
            stack.Push(c1); // Push first complex number onto the stack

        }
        static void Main1(string[] args)
        {
            Stack<int> stack = new Stack<int>(5); // Create a stack of integers with size 5
            stack.Push(10); // Push 10 onto the stack
            stack.Push(20); // Push 20 onto the stack
            //Console.WriteLine(stack);
            
            Console.WriteLine("$$$$$$$$");

            Stack<string> stringStack = new Stack<string>(5); // Create a stack of strings with size 5
            stringStack.Push("Hello"); // Push "Hello" onto the stack
            //Console.WriteLine(stringStack);
            Console.WriteLine("$$$$$$$$$");
        }
    }
}

using System.Security.Cryptography;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(10,20);
            Rectangle r2 = new Rectangle(15,5);
            if(r1.Equals(r2)) // This will call the Equals method of the Rectangle class, which is inherited from the Shape class.
            {
                Console.WriteLine("equals");

            }
            else
            {
                Console.WriteLine("not equals");
            }
            Console.WriteLine("^^^^^^^^^^^^");

            Tranagle t1 = new Tranagle(10, 20);
            Tranagle t2 = new Tranagle(10, 20);
            if (t1.Equals(t2)) // This will call the Equals method of the Tranagle class, which is inherited from the Shape class.
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("not equals");
            }
            Console.WriteLine("^^^^^^^^^^^^");

            if (t1 == t2) // This will call the Equals method of the Tranagle class, which is inherited from the Shape class.
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("not equals");
            }
            Console.WriteLine("^^^^^^^^^^^^");

            if(object.ReferenceEquals(t1, t2)) // This checks if both references point to the same object in memory.
            {
                Console.WriteLine("same reference");
            }
            else
            {
                Console.WriteLine("different reference");
            }
            // static method equals works on reference types


            //Main1(args);
            //Main2();
        }
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //inheritance
            Shape s1 = new Shape(10, 20);
            s1.print();
            Console.WriteLine("^^^^^^^^^^^^^^");

            Rectangle r1 = new Rectangle(1, 20);
            r1.print();
            Console.WriteLine("rectangle");
            Console.WriteLine(r1.Area());
            Console.WriteLine("^^^^^^^^^^^^^^");

            Tranagle t1 = new Tranagle(10, 10);
            t1.print();
            Console.WriteLine("trangle");
            Console.WriteLine(t1.Area());
            Console.WriteLine("^^^^^^^^^^^^^^");

            object o1;
            o1 = t1;
            Console.WriteLine(o1.ToString());// This will call the ToString method of the Tranagle class, because it overrides the ToString method of the Shape class
            Console.WriteLine("^^^^^^^^^^^^^^");

            //abstract class
            //Shape2 s2 = new Shape2(10, 20);// This will not work because Shape2 is an abstract class and cannot be instantiated directly.

            //abstract method should be in abstract class , not vice versa
            Shape2 s2;
            s2 = new Rectangle(10, 20); // This will work because Rectangle is a concrete class that inherits from Shape2 and implements the abstract method GetShapeType.

        }
        public static void Main2()
        {
           
            Rectangle r = new Rectangle();
            Shape2 s2 ;
            Tranagle t = new Tranagle();
            s2 = r;
            s2 = t;
            //s2 = new Abc(); // This will not work because Abc is a nested class inside Rectangle and cannot be instantiated directly.

           // t = (Tranagle)s2; // Using 'as' operator for safe casting
            if (t == null)
            {
                Console.WriteLine("s2 is not a Tranagle");
            }
            else
            {
                Console.WriteLine("s2 is a Tranagle");
            }
            ////is , as 
            //if (s2 is Rectangle)
            //{
            //    Console.WriteLine("s2 is a Rectangle");
            //    r = (Rectangle)s2;
            //}
            //else if (s2 is Tranagle)
            //{
            //    Console.WriteLine("s2 is a Tranagle");
            //    t = (Tranagle)s2;
            //}
            //else
            //{
            //    Console.WriteLine("s2 is neither a Rectangle nor a Tranagle");
            //}

            //is , as in referance types
            //casting ??
        }
    }
}

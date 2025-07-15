using System.Diagnostics;

namespace Demo4

{
    internal class Program
    {
        
        //call by reference(alias name)
        public static void Swap(ref int a,ref  int b) //in , out
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Calc(int x, int y , out int sum , out int sub , out int mul)
        {
            Console.WriteLine($"Sum = {x + y}");
            Console.WriteLine($"Sub = {x - y}");
            Console.WriteLine($"Mul = {x * y}");
            Console.WriteLine($"Div = {x / y}");
            sum = x + y;
            sub = x - y;
            mul = x * y;// we need all data to be out
        }
        public void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int s,sub, mul;
            //swapping 
            //Swap(x,y);//call by value
            Swap(ref x, ref y); //call by reference
            Console.WriteLine($"x = {x}, y = {y}"); // x = 20, y = 10
            
            Calc(x, y, out s, out sub, out mul);
            
            StackMain();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        public static void func2()
        {
            int o = 8;
            Console.WriteLine(o);
            StackTrace stackTrace = new StackTrace();
            foreach (var item in stackTrace.GetFrames())
            {
                Console.WriteLine(item.GetMethod().Name);

            }
        }
        public static void func1(int a) {
            Console.WriteLine(a);
            int z = 30;
            func2();

        }
        static void StackMain()
        {
            int x = 10;
            int y = 20;
            func1(y);
            Console.WriteLine("**********");
            Structuse(args: null);
        }
        static void Structuse(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Demo4.Complex complex = new Demo4.Complex(3, 4) { Real = 30, Imaginary = 50 };//object initializer
            Console.WriteLine(complex.ToString());
            Complex complex2 = new Complex(5, 6); //using constructor
            complex = complex2; //using assignment (value equality)
            Console.WriteLine(complex.ToString());
            complex.Real = 100; //using property
            Console.WriteLine(complex2.ToString());
            Console.WriteLine(complex.ToString());
            if (complex.Equals(complex2))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
    }

}

namespace Demo1
{
    delegate int del1(int a, int b);
    delegate double del2(double a, double b);
    delegate T del<T>(T a, T b);
    internal class Program
    {
        //instance method
        public int Add(int a, int b)
        {
            return a + b;
        }
        //static method
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
           del1 d1 = new Program().Add; // instance method
            del1 d2 = Subtract; // static method
            del1 d3 = Multiply; // static method
            int result1 = d1(10, 20);
            int result2 = d2(20, 10);
            int result3 = d3(5, 4);
            Console.WriteLine($"Add: {result1}");
            Console.WriteLine($"Subtract: {result2}");
            Console.WriteLine($"Multiply: {result3}");

            Console.WriteLine("^^^^^^^^^^");

            del2 d4 = (a, b) => a / b; // lambda expression for division
            double result4 = d4(10.0, 2.0);
            Console.WriteLine($"Divide: {result4}");

            //build in 
            Func<int, int, int> addFunc = (a, b) => a + b; // Func delegate for addition
            Action<int> action = (a) => Console.WriteLine($"Action: {a}"); // Action delegate for printing

            var d0 = Subtract; // Assigning the static method to a delegate

            Func<int,int , int> m1 = delegate(int a, int b)
            {
                return a + b; // Anonymous method for addition
            };
            Console.WriteLine(m1.Invoke(10, 20));  // Calling the anonymous method
        }
    }
}
//1- create delegate
//2- create a method  (instance method) that takes parameters and returns  value or (static method)
//3- reference the delegate 
//4-call the method with the delegate as a parameter

//delegate inherits from MulticastDelegate (invokating list)

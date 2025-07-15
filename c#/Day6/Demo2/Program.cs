using System.Security.Cryptography.X509Certificates;

namespace Demo2
{
    //1- Define a delegate
    public delegate void del1();
    internal class Program
    {
        public static void print1()
        {
            Console.WriteLine("print1");
        }
        public static void print2()
        {
            Console.WriteLine("print2");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //2- Create a delegate instance , point to a function
            del1 m1 = print1; // take name of function
            m1.Invoke(); // call the function using delegate

            //invocation list
            m1 += print2; // add another function to the delegate

            func(m1); // call the function using delegate
            m1.GetInvocationList(); // get the list of functions in the invocation list

            PublicKey static void func(del1 m)
            {
                m.Invoke(); // call the function using delegate
            }
        }
    }
}

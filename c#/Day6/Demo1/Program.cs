namespace Demo1
{
    //1- Define a delegate
    public delegate int del1(int a, int b);
    internal class Program
    {
        //3- define functions that match the delegate signature
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int result = Add(3, 4);
            //2- Create a delegate instance , point to a function
            del1 m1 = new del1(Add); // take name of function
            del1 m2 = Sub; // can also use method group conversion

            int x = 10;
            int y = 5;
            int z;
            //4- call function using delegate
            z = (int)(m1?.Invoke(x, y)); // call the function using delegate

            z = m1(x, y); // can also call without Invoke
            Console.WriteLine(z);
        }
    }
}

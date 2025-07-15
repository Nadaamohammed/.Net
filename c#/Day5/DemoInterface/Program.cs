namespace DemoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int[] arr = { 1, 2, 3, 4, 5 };
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("^^^^^^^^^^");
            string[] arr2 = { "b", "a", "c" };
            Array.Sort(arr2);
            Console.WriteLine("^^^^^^^^^^");

            Complex[] complexArr = {
                new Complex(1, 2),
                new Complex(3, 4),
                new Complex(5, 6)
            };
            Array.Sort(complexArr); //doesn't work
            foreach (var item in complexArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("^^^^^^^^^^");

            IComparable[] comparableArr = {
                new Complex(3, 4),
                new Complex(1, 2),
                new Complex(10, 4),
                new Complex(5, 6)
            };
            Array.Sort(comparableArr); //works
foreach (var item in comparableArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}

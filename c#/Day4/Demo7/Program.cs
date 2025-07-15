namespace Demo7
{
    internal class Program
    {
        static void func2() {
            int x;
            int y;
            int[] arr = new int[5];
            int z = 1;

            //format exception (x or y is chars)
            try {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = x / y;
                Console.WriteLine(z);

            }
            catch(FormatException ex) {
                Console.WriteLine("format error");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("divide by zero error");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("general error");
                Console.WriteLine(ex.Message);
            }
            finally //if exception it execute or not 
            {
                Console.WriteLine("finally block executed");
            }
            
        }
        static void func1() {
            func2();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            func1 ();
        }
    }
}

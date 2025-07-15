namespace math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);  

            
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2); 

            // Multiply the numbers
            int result = number1 / number2;

            
            Console.WriteLine("The result : " + result);


            string s = "nada";
            int i = 0;
            float f = 1.20f;
            char c = 'a';
            double d = 1.0;
            bool b = true;
            Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(b);
        }

    }
}

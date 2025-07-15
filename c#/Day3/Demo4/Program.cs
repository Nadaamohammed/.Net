namespace Demo4
{
    struct Complex
    {
        // Fields
        private double Real;
        private double Imaginary;
        // Constructor
public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        // Properties
        public void SetReal(double real)
        {
            Real = real;
        }
        public void SetImaginary(double imaginary)
        {
            Imaginary = imaginary;
        }
        public double GetReal()
        {
            return Real;
        }
        public double GetImaginary()
        {
            return Imaginary;
        }
        public void print()
        {
            Console.WriteLine($"Real: {Real}, Imaginary: {Imaginary}");
        }
        public void result()
        {
            if (Imaginary >= 0)
            {
                Console.WriteLine($"{Real} + {Imaginary}i");
            }
            else if (Imaginary < 0)
            {
                Console.WriteLine($"{Real} - {-Imaginary}i");
            }
            else
            {
                Console.WriteLine("Invalid Complex Number");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //struct is value type
            Complex c1 = new Complex();
            c1.SetReal(3.0);
            c1.SetImaginary(4.0);
            c1.print();
            c1.result();
            double x = c1.GetReal();

        }
    }
}

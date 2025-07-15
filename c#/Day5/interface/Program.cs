namespace  interfacee;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        OddSeriescs o = new OddSeriescs();
        //Console.WriteLine(o.GetNextNumber());
        //Console.WriteLine("^^^^^^^^^^");
        SeriesEngin se = new SeriesEngin();
        se.PrintNextNumber(o);
        se.PrintNextNumber(o);
        se.PrintNextNumber(o);
        Console.WriteLine("^^^^^^^^");
        EvenSeries e = new EvenSeries();
        se.PrintNextNumber(e);
        se.PrintNextNumber(e);
        se.PrintNextNumber(e);
        Console.WriteLine("^^^^^^^^");

        Cla cla = new Cla();
        se.PrintNextNumber(cla);
        Console.WriteLine("^^^^^^^^");

        Fib fib = new Fib();
        se.PrintNextNumber(fib);
        se.PrintNextNumber(fib);
        se.PrintNextNumber(fib);
        Console.WriteLine("^^^^^^^^");

        IMath math = new math();
        Console.WriteLine(math.add(10, 20));


    }
}


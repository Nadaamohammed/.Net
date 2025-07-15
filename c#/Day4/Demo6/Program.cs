namespace Demo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Coplex coplex1 = new Coplex(10, 20);
            Coplex coplex2 = new Coplex() { Img=20 , Real=10};
            Console.WriteLine(coplex1);
            Console.WriteLine(coplex2);
            Coplex coplex3 = new Coplex();
            Console.WriteLine(coplex3);
            coplex1 = coplex2 + coplex3;
            Console.WriteLine(coplex1);

            coplex1 = coplex2; // coplex1 == coplex2; // This will work, but it will not compare the values, it will compare the references
            //equal operator can't do overloading, so we need to override the Equals method (componed operator)
            Console.WriteLine(object.ReferenceEquals(coplex1,coplex3));
            if (coplex1 == coplex2) // if there is assign to same place in memory, this will work
            {
                Console.WriteLine("coplex1 is equal to coplex2");// This will not work unless you override the == operator
            }
            else
            {
                Console.WriteLine("coplex1 is not equal to coplex2");
            }
            coplex2 += coplex3; // This will work, but it will not compare the values, it will compare the references
            coplex2++; // This will work, but it will not compare the values, it will compare the references
            Console.WriteLine(coplex2);

            Coplex cp3 = new Coplex(10, 20);
            cp3 = null;
            Console.WriteLine(cp3?.Real);

        }
    }
}

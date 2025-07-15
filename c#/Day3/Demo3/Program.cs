using System.Runtime.Intrinsics.X86;

namespace Demo3
{
    

    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday = 10
    }
    enum gender :byte
    {
        male,
        female
    }
    enum code : short
    {
        code1 = 100,
        code2 = 200,
        code3 = 300
    }
    [Flags]
    enum permission :byte
    {
        read=1,
        write=2,
        execute=4, 
        modify=8
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            DaysOfWeek dn1 = DaysOfWeek.Saturday;
            Console.WriteLine(dn1);
            dn1 = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
            Console.WriteLine(dn1);
            //dn1 = Enum.Parse<DaysOfWeek>(Console.ReadLine());
            Console.WriteLine("#############");

            //restricted data using enum
            // enum can't using string data
            //parse return object type
            gender g1 = gender.female;
            Console.WriteLine(g1);
            g1 = (gender)Enum.Parse(typeof(gender), Console.ReadLine());
            Console.WriteLine(g1);
            //g1 , dn1 are elise name to  integer type
            //Enum.GetNames(typeof(DaysOfWeek)).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("#############");
            code c1 = code.code2;
            Console.WriteLine(c1);
            c1 = (code)300;
            c1 = (code)Enum.Parse(typeof(code), Console.ReadLine());
            Console.WriteLine(c1);
            Console.WriteLine("#################");
            //permission in restricted data , have many values
            permission p1 = permission.read;
            p1 ^= permission.write; // i nead to be write & read
            // bitwise xor operation
            Console.WriteLine(p1);// output: read, write = 3

            int x = 0xa; // 10 in decimal
            Console.WriteLine(x);
            int y = 0b1; // 1 in binary

        }
    }
}

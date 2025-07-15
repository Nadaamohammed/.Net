namespace Demo3
{
    internal class Program
    {
        static void Main()
        {
            int x = 10;
            float y = 2.0f;
            string s1 = "Hello";
            object o = x; //boxing, implicit conversion from value type to object
            Console.WriteLine($"{o}:{o.GetType()}");
            o = y;
            Console.WriteLine($"{o}:{o.GetType()}");
            o = s1;
            Console.WriteLine($"{o}:{o.GetType()}");

            int z = 30;
            //z = o;//compilation error, cannot convert object to int directly
            z = (int)o; //explicit conversion from object to int, will throw exception if o is not an int

            Nullable(args:null);
            Console.WriteLine("#######");
            //Casting(args: null);
            //unboxing --> explicit conversion from object to value type , unsafe , convert stack to heap
            //boxing --> implicit conversion from value type to object
        }
        static void Nullable(string[] args)
        {
            //value type
            Nullable<int> age = null;
            int? age2 = null; //using nullable type
            short? s1 = null; //using nullable type
            short s2 = 10; //normal short
            s1 = s2; //implicit conversion from short to nullable short
            Console.WriteLine(s1); //prints 10
            //s2= s1 ;error: cannot convert nullable short to normal short
            if (s1 != null) {
                //s2 = s1.Value; //explicit conversion from nullable short to normal short
                s2 = (short)s1; //explicit conversion from nullable short to normal short
            } else {
                Console.WriteLine("s1 is null, cannot convert to short");
            }

           // s2 = (short)s1; //explicit conversion from nullable short to normal short
            Console.WriteLine(s2); //prints 10

            s2=s1.HasValue ? (short)s1 : (short)0; //using null-coalescing operator (trunry operator)

            s2 = s1 ?? 0; //using null-coalescing operator .. s1=null--> 0 , s1=value-->value

            var x = 10;
        }
        static void Casting(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Int32 x = 32768;
            Int16 y = 20;
            long l = 2;
            float f = l;
            decimal d = (decimal)10.5;
            double d2 = (double)d; //explicit conversion from decimal to double
            y = Convert.ToInt16(x); //explicit conversion from larger to smaller type
            x = y; //implicit conversion from smaller to larger type
            Console.WriteLine(x);
            //overflow example
            checked
            {
                unchecked
                {
                    y = (Int16)x; //explicit conversion from larger to smaller type

                }
            }
           
            Console.WriteLine(y);
            string s = null;
            y = Convert.ToInt16(s); //null value conversion, will throw exception
            y = short.Parse(s); //null value parsing, will throw exception

        }
    }
}

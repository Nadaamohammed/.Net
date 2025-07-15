// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using static System.Console;
namespace Demo4
{
    class Program
    {
        //int , float , char , bool
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine(".net framework");
            WriteLine("my nmae is nada");
            
            short s;//2byte+ sign (32767 >=-32768)
            int i;//4byte+ sign (2147483647 >=-2147483648)
            long l;//8byte+ sign (9223372036854775807 >=-9223372036854775808)
            byte b; //1byte (255 >=0) unsigned
            sbyte sb; //1byte+ sign (127 >=-128) signed
            ushort us; //2byte (65535 >=0) unsigned
            ulong ul; //8byte (18446744073709551615 >=0) unsigned
            double d; //8byte (14-15 after . )
            float f = 2.3f; //4byte ( 7-8 after . )
            decimal pc = 2.3m; // money (28-29 after . )
            char c = 'a'; //2byte (unicode) (0-65535) unsigned
            char.IsAscii(c); // check if the character is ASCII
            bool isTrue = true; //1byte (true or false)
            string str = "hello"; // reference type (array of char) (null or empty)

            object obj = new object(); // base type for all types in C#
            obj = 10; // boxing (converting value type to reference type)
            obj.ToString();
            //cts:common type system (value type--> all without object&string , reference type, pointer type, enum type, struct type, interface type, array type, delegate type)
            //CTS defines how types are declared, used, and managed in the runtime.

            Console.WriteLine(byte.MaxValue);
            Console.WriteLine("Enter a short value:");


            
        }
    }
}

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 0;
            x = int.Parse(Console.ReadLine());//return string , string to int
            Console.WriteLine(x);
            int z = Console.Read() - '0'; //read char and convert to int
            ConsoleKeyInfo s =Console.ReadKey();//wait for key press
            Console.WriteLine("#################");
            WriteData(args);
            
        }
        static void  WriteData(string[] args)
        {
            int x= 10, y=30 ;
            float f = 10.5f;
            Console.WriteLine("x={0} y={1}",x,y);
            Console.WriteLine($"x={x} y={y} z={f:c}");//string interpolation
            string path = @"\Demo2\\Program.cs";//verbatim string
            Console.WriteLine("#################");
            Differncebetweenvalref(args);
            Console.WriteLine("#################");
            StringEx();
            
        }
        static void StringEx()
        {
            //act as value equality
            //immutable object
            string s1 = "aly";
            string s2 = "ahmed";
            s1 = s2; //reference equality copy
            Console.WriteLine(s1);//ahmed
            Console.WriteLine(s2);//ahmed
            s1 ="nada";
            Console.WriteLine(s1);//nada
            Console.WriteLine(s2);//ahmed
            s1+=s2; //concatenation
            Console.WriteLine(s1);//nadaahmed
           

        }
        static void Differncebetweenvalref(string[] args)
        {
            #region value types
            int x = 10; //stack
            int y = 20; //stack
            x = y;//value eqalue copy
            Console.WriteLine(x);
            Console.WriteLine(y);
            #endregion

            #region reference types
            //intialize by default
            //object . string , array
            int[] arr1 = new int[] { 1, 2, 3 }; //heap
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            //Console.WriteLine(default(int)); 
           // Console.WriteLine("##############");
            char[] arr2 = new char[] { 'a', 'b', 'c' }; //heap
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            int[] arr3 = new int[] { 4, 5, 6 }; //heap
            arr1 = arr3; //reference copy
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr3[i]);
            }
            #endregion
        }
    }
}

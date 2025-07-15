namespace Demo3
{
    public delegate bool del(int x, int y);
    public delegate void del2();

    //generic delegate
    public delegate t del3<t>(t x, t y);
    public delegate t3 del4<in t1, in t2 , out t3>(t1 x, t2 y);// in--> input , out--> output
    internal class Program
    {
        public static bool cond1(int x, int y)
        {
            return x > y;
        }
        public static bool cond2(int x, int y)
        {
            return x < y;
        }
        public static bool Iscon(int a)
        {
            return a > 30;
        }
        public static void print()
        {
            Console.WriteLine("Hello from print method");
        }   
        static void Main(string[] args)
        {
            List<int> num = [1,2,4,569,79];

            del z =  delegate(int a , int y)
            {
                return a < 100;
            } //anonymous method
            ;

            del x =  ( a, y)=>
            {
                return a < 100;
            } //lambda expression
            ;

            List<String> names = ["nada" , "ahmed","morad"];


            //delegate point to function take data int return bool
            num.FindAll(Iscon);
           
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************");


            del m1 = cond1;
            m1 = cond2;
            m1+= x; //adding lambda expression to delegate

            int[] arr1 = { 1, 2, 4, 5, 6, 7, 8, 9 };
            Sorting.Sort(arr1,m1);
            Sorting.Sort(arr1, z);
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************");
            


            var n= names.FindAll((x) => x.StartsWith("a"));
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(n);


            del2 d = print; //delegate point to function take no data return void
            Action d2 = print; //Action delegate point to function take no data return void
            d += ()=> Console.WriteLine("Hello from lambda expression"); //adding lambda expression to delegate


            del3<int> d3 = (x, y) => x + y; //generic delegate
            del3<string> d4 = (x, y) => x + y; //generic delegate with string
            Func<int, int, int> d5 = (x, y) => x + y; //Func delegate
            Console.WriteLine(d3(10, 20)); //output: 30
            Console.WriteLine(d4("Hello ", "World")); //output: Hello World
        }
        //func() --> automatic delegate point to function take data and return value , 16 parameters
        //action() --> automatic delegate point to function take data and return void , 16 parameters
        //predicate() --> automatic delegate point to function take data and return bool , 16 parameters
        //event --> delegate point to function take no data and return void , 16 parameters
        //eventhandler --> delegate point to function take data and return void , 16 parameters
    }
}

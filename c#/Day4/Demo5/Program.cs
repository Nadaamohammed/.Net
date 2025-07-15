namespace Demo5
{
    internal class Program
    {
        public static int add (int x , int y)
        {
            return x + y;
        }
        public static void Display(int[] arr2)
        {
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

        }
        public static void array()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Display(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            arr[0] = 100; //change value
        }
        //params
        public static int Mull(string s,params int[] arr)//variable lenght parameter
        {
            //only 1 params , and at the end
            int res = 1;
            foreach (var item in arr)
            {
                res *= item;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 0;
            int b = 30;
            string s = "he";
            int z =add(x:a , y:b);//x=a,y=b
            int c = add(y:a , x:b);
            Console.WriteLine(z);

            int m = Mull(s,a , b);
            Mull(s,a,b,c);
        }
    }
}

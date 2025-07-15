using System.Collections;
namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            LinkedList<int> linkedList = new LinkedList<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            HashSet<int> hashSet = new HashSet<int>();

            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            foreach (KeyValuePair<int , string> k in dict)
            {
                Console.WriteLine(value: $"Key: {k.Key}, Value: {k.Value}");
            }
            // Console.WriteLine("Hello, World!");
            //Main1(args);
        }
        static void Main1(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            int[] arr = new int[5] { 10, 20, 30, 5, 4 }; //fixed
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(arr[3]);
            Console.WriteLine("^^^^^^^^^");
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            foreach (object o in al)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(al.Count);
            Console.WriteLine("^^^^^^^^^^^");

            List<int> list = new List<int>(); //not fixed size , generic
            list.Add(10);
            list.Add(20);
            list.Add(30);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list[1] = 111; // Update the second element 
            list.Sort(); // Sort the list , IComparable
            Console.WriteLine("^^^^^^^^^^^");
            List<string> strList = new List<string>(10);
            Console.WriteLine(strList.Count);
            Console.WriteLine(strList.Capacity);
            strList.TrimExcess(); // Reduce the capacity to match the count

        }
    }
}
using System.Runtime.InteropServices;

namespace Demo2
    delegate bool del1(int a, int b);
{
    //subscriber
    internal class Program
    {
        public static void SortAndPrint(List<char> characters)
        {
            characters.Sort();
            foreach (var character in characters)
            {
                Console.WriteLine(character);
            }
        }
        public static bool startsWithA(char c)
        {
            if (c == 'a')
            {
               return true;
            }
            else
            {
                return false;
            }
        }
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int subtract(int a, int b)
        {
            return a - b;
        }
        public static List<int> list1 (List<int> list , Func<int,bool>m1)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (m1.Invoke(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    public static bool Cond1(int a, int b)
        {
            return a < b;
    }
    static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 3, 8, 6, 2 };
            var rest = list1(numbers ,(x)=> x>3);
            List<char> characters =[ 'd', 'a', 'c', 'b' ];

            Predicate<char> starts = startsWithA;
            var res = characters.FindAll(starts);

        int[] num = { 5, 3, 8, 6, 2 };

        // Using Func<int, int, int> for addition
        Func<int, int, int> addFunc = add;
        Console.WriteLine("Sum of 3 + 4 = " + addFunc(3, 4));

        // Using your custom delegate for comparison
        del1 m = (a, b) => a < b;

        // Sorting in descending order using lambda
        Sorting.Sort(num, (a, b) => a < b); // ascending
        Sorting.Sort(num, (a, b) => a > b); // descending


    }
}
}

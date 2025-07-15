namespace template
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ObjectStack s = new ObjectStack(5);
            //no type safety, can push any object
            //boxing
            s.Push("Hello");
            s.Push(123);
            s.Push(45.67f);
            s.Push(new DateTime(2023, 10, 1));
            s.Push(new { Name = "Anonymous", Age = 30 });
            Console.WriteLine(s);
            Console.WriteLine("***************");
            while (!s.IsEmpty())
            {
                Console.WriteLine(s.Pop());
            }
            Console.WriteLine(s);
            
        }
    }
}

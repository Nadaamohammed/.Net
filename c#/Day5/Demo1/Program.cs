namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Stack stack = new Stack(5);


            //push
            try
            {
                stack.Push(10);
                stack.Push(20);
                stack.Push(30);
                stack.Push(40);
                stack.Push(50);
                //stack.Push(60); // This will throw StackFullException
                Console.WriteLine(stack);
            }
            catch (StackFullException ex)
            {
                Console.WriteLine(ex.Message); // Output: Stack is full
            }


            //pop
            try
            {
                while (true)
                {
                    Console.WriteLine(stack.Pop()); // This will pop items until the stack is empty
                }
            }
            catch (StackEmptyException ex)
            {
                Console.WriteLine(ex.Message); // Output: stack is empty
            }
        }
    }
}

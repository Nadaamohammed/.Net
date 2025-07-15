namespace first
{
    internal class Program
    {
        static void Main(string[] args)
            //args[0]--> run program 
            //args[1] --> var
        {
            int apples = 5 + 3 + 5;
            Console.WriteLine("I have " + apples + " apples!");
            int class = 5; // This is not a valid variable name, it should start with a letter or underscore
            string _name = "John"; // Valid variable name, starts with an underscore

        }
    }
}

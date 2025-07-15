namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee");

            Employee emp = new Employee() { Id=2 , Name="nada",Salary=10000};
            Employee emp2 = emp; //reference copy
            emp2.Name = "Nada";
            Console.WriteLine(emp);
            //emp.salary = 1000; doen't create in heap

            //create ref in stack 
            //allocate memory in heap data of type Employee
            //initilize // cross out according to constructor
            //call constructor
            //update refrrence
            emp.Salary = 1000; //create in heap

            if(emp == emp2)
            {
                Console.WriteLine("emp and emp2 are same");
            }
            else
            {
                Console.WriteLine("emp and emp2 are different");
            }
        }
    }
}

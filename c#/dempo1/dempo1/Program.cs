namespace dempo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region linq
            //LINQ
            //40 method 
            //Enumerable class (partial class)

            List<int> numbers = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
            var res = Enumerable.Where(numbers , x => x > 2 & x<10);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("^^^^^^^^^^^^^");

            // immediate execution
           
            var res2 = numbers.Where(x => x > 2 && x < 10).ToList();

          //defered excution
            numbers.Add(11); // add new item to the list
            #endregion

            #region hash
            var x = 30;//int x = 30; , implicitly typed variable
            //var x; error 
            x = 234; // x is still an int
            Console.WriteLine(x.GetType());
            Console.WriteLine("^^^^^^^^^^^^^");
            object o = 10; //
            o = "Hello"; // boxing and unboxing


            Employee emp = new Employee(1, "John Doe", "IT", 50000);
            Console.WriteLine(emp.ToString());
            Console.WriteLine("^^^^^^^^^^^^^");

            var emp2 = new { Id = 1, Name = "Nada", Department = "cs", Salary = 50000 }; // anonymous type
            Console.WriteLine($"Id: {emp2.Id}, Name: {emp2.Name}, Department: {emp2.Department}, Salary: {emp2.Salary}");
            Console.WriteLine(emp2.GetType());
            Console.WriteLine("^^^^^^^^^^^^^");

            if (emp.Equals(emp2))
            {
                Console.WriteLine("emp and emp2 are equal");
            }
            else
            {
                Console.WriteLine("emp and emp2 are not equal");
            }
            //emp2.Id = 2; 
            // error, anonymous type is immutable
            //overide equals , gethashcode and tostring in Employee class
            //c# compoler generate datatypes

            Console.WriteLine("^^^^^^^^^^^^^");
            int xx= 123;
            int y = 20;
            Console.WriteLine(MyMath.Add(xx,y));


            //extention method
            Console.WriteLine(xx.Add(y));
            Console.WriteLine("^^^^^^^^^^");

            Console.WriteLine(xx.mirror());
            Console.WriteLine("^^^^^^^^^^");
            #endregion

            #region start
            Action a1 = () => Console.WriteLine("Hello from Action");
            a1.Invoke(); // or a1(); both are valid

            Action <int> a2 = (x) => Console.WriteLine($"Hello from Action with parameter: {x}");
            a2.Invoke(10); // or a2(10); both are valid

            Action<int, int, float > a3 = (x, y , z) => Console.WriteLine(x+y+z);
            a3.Invoke(10, 20, 30.5f); // or a3(10, 20, 30.5f); both are valid
            Console.WriteLine("^^^^^^^^^^");

            //return value
            Func<int, int, double > addFunc = (a, b) => a + b;
            Console.WriteLine(addFunc.Invoke(10, 20)); // or addFunc(10, 20); both are valid

            //bool return value
            Predicate<int> isEven = (x) => x % 2 == 0;
            Console.WriteLine(isEven.Invoke(10)); // or isEven(10); both are valid

            #endregion


        }
    }
}

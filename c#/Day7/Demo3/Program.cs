using System.Security.Cryptography;
using Users;
namespace Demo3
{
    internal class Program
    {
        private static int absentDays;

        public static string Name { get; private set; }
        public static int Id { get; private set; }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Student s1 = new Student(Id = 1, Name = "nada", absentDays = 4);
            Student s2 = new Student(Id = 2, Name = "ahmed", absentDays = 1);
            Student s3 = new Student(Id = 3, Name = "momo", absentDays = 2);


            Department department = new Department(1, "IT", "Cairo", new List<Student> { s1, s2, s3 });
            Console.WriteLine(department);
            department.AddStudents(new Student(4, "Ali", 3));

            Console.WriteLine("^^^^^^^^^^^^");
            Clubcs club = new Clubcs(Name="cairo");
            Clubcs club2 = new Clubcs(Name = "cairo");
            club.AddStudent(s1);

            Department d1 = new Department( "HR");
            //d1.AddStudent(s1);
            d1.AddStudents(s2);
            d1.AddStudents(s3);
            club2.AddStudent(s2);
            club2.AddStudent(s3);

            s2.SetAbsentDays(6); // This will trigger the event and remove the student from the club
            d1.print();
            club2.Print();
        }
    }
}

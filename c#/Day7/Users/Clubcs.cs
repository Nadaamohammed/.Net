using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Clubcs
    {
        public string Name { get; set; }
         List<Student> students = new List<Student>();

        public Clubcs(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            student.StudentFired += RemoveStudent; // Subscribe to the event
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void Print()
        {
            Console.WriteLine($"Club Name: {Name}, Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }
    }
}

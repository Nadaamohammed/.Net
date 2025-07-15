using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    //subscriber , event handler
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        List<Student> Students = new List<Student>();
        public Department(int id, string name, string location, List<Student> students)
        {
            Id = id;
            Name = name;
            Location = location;
            Students = new List<Student>(students);
        }
        public Department()
        {
            Id = 1;
            Name = "Default Department";
            Location = "Default Location";
            Students = new List<Student>();
        }
        public Department(string name)
        {
            
            Name = name;
           
        }
        public void AddStudents(Student student)
        {
                Students.Add(student);
                student.StudentFired += RemoveStudents; // 2-Subscribe to the event
            
            
        }
        public void RemoveStudents(Student student)
        {
            
                Students.Remove(student);
        }
        public void print()
        {
            Console.WriteLine($"departmentName:{Name} \n students:");
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }
        public override string ToString()
        {
            return $"Department  Name: {Name}, Students Count: {Students.Count}";
        }
    }
}

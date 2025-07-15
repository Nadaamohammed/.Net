using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dempo1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public Employee(int id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Department: {Department}, Salary: {Salary}";
        }
    }
}

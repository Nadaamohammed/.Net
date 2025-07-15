using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Employee //implecnt inhereitance from object
    {
        int id;
        string name;
        float salary;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get => name;
            set {
                if (value.Length > 5)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"Invalid {value}");
                }
                 }
        }
        public float Salary
        {
            get { return salary; }
            set {
                if (value >= 3000)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine($"Invalid {value}");
                }
            }
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
        public Employee() //default constructor
        {
            
        }
        public Employee(int id, string name, float salary) //parameterized constructor
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
    }
}

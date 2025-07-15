using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    //publisher
    //it has a info that i can use it to take a decision
    public class Student
    {
        //1- event
        public event Action<Student> StudentFired;


        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        int absentDays;

        public Student()
        {
            
            Name = "Default Name";
            absentDays = 0;

        }
        public Student(int id, string name, int absentDays = 0)
        {
            Id = id;
            Name = name;
            this.absentDays = absentDays;
        }
        public int GetAbsentDays()
        {
            return absentDays;
        }
        public void SetAbsentDays(int days)
        {
            absentDays += days;
            if (days > 5)
            {
                StudentFired?.Invoke(this); //3- fire the event
            }
           
        }
        public override string ToString()
        {
            return $"{Id} - {Name} - {Age} - {absentDays}";
        }
        
    }
}

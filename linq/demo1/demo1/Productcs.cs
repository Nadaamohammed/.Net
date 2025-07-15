using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    public  class Productcs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string category { get; set; }
        public decimal Discount { get; set; }
        public int unitsinstock { get; set; }
        // Default constructor
        
        public Productcs()
        {
            Id = 0;
            Name = string.Empty;
            Price = 0.0m;
            category = string.Empty;
            Discount = 0.0m;
            unitsinstock = 0;
        }
        public Productcs(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price:C}";
        }
        public int CompareTo(Productcs other)
        {
            if (other == null) return 1; // null is considered less than any instance
            return this.Id.CompareTo(other.Id);
        }
    }
}

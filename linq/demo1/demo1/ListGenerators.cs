using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    public static class ListGenerators {
        public static List<Productcs> ProductsList;
        static ListGenerators() {
            ProductsList = new List<Productcs>
            {
                new Productcs(1, "Laptop", 1200.00m) { category = "Electronics", Discount = 0.1m, unitsinstock = 50 },
                new Productcs(2, "Smartphone", 800.00m) { category = "Electronics", Discount = 0.15m, unitsinstock = 100 },
                new Productcs(3, "Tablet", 400.00m) { category = "Electronics", Discount = 0.05m, unitsinstock = 75 },
                new Productcs(4, "Headphones", 150.00m) { category = "Accessories", Discount = 0.2m, unitsinstock = 200 },
                new Productcs(5, "Smartwatch", 250.00m) { category = "Wearables", Discount = 0.1m, unitsinstock = 150 }
            };
        }

    }
    
    }

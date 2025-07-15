using System.Linq;
namespace demo1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>
            //{
            //    "Alice",
            //    "Bob",
            //    "Charlie"
            //};
            //var res = Enumerable.Where(names, name => name.Length > 3);
            //var res2 = names.Where(name => name.Length > 3);//fluent syntax 


            //var res3 = from p in names
            //           where p.Length > 3
            //           select p; //query syntax

            //foreach (var name in res)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine("$$$$$$$$$");

            Productcs[] products = ListGenerators.ProductsList.ToArray();
            //products.Length;


            var res = products.Where(p => p.Price > 500 && p.category == "Electronics")
                              .OrderByDescending(p => p.Price)
                              .Select(p => new { p.Id, p.Name, p.Price, p.category });
            foreach (var p in res)
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price:C}, Category: {p.category}");
            }
            Console.WriteLine(
               "^^^^^^^^^^^^");

            var res2 = from p in products
                       where p.Price > 500
                       select new { p.Id, p.Name, p.Price, p.category };

            foreach (var p in res2)
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price:C}, Category: {p.category}");
            }
            Console.WriteLine(
                "^^^^^^^^^^^^");
            //indexed query
            var res3 = products.Where(p => p.Price > 200)
                .OrderByDescending(p => p.Price)
                .Select((p, index) => new { Index = index, p.Id, p.Name, p.Price, p.category });

            foreach (var p in res3)
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price:C}, Category: {p.category}");
            }
            #region natural ordering operators --> take skip takewhile skipwhile 

            var res4 = products
                .Take(3); //take first 3 elements
            var res5 = products
                .Skip(2); //skip first 2 elements

            #endregion
            Console.WriteLine("^^^^^^^^^^^^");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var les = numbers.First( a => a<5);
            var last = numbers.Last(a => a > 5);
            var sin = numbers.Single (a => a == 8);
            var def = numbers.SingleOrDefault(a => a == 11); //returns default value if no element found, in this case 0



            List<string> input = ["apple", "banana", "cherry", "date", "elderberry"];
            var name = input.SelectMany(a => a);
            //union apply redundant elements
            //concate doesnat apply redundant elements
            // any --> at least one element satisfies the condition
            //group by --> groups elements based on a key
            var grouped = products.GroupBy(p => p.category)
                .Select(g => new { Category = g.Key, Products = g.ToList() });
            foreach (var group in grouped)
                {
                Console.WriteLine($"Category: {group.Category}");
                foreach (var product in group.Products)
                {
                    Console.WriteLine($"  Id: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
                }
            }
        }
    }
}

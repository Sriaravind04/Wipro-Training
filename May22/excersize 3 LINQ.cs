using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Program34
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> { 
                new Product {Name = "laptop", Price = 10000},
                new Product {Name = "Mouse" , Price =20000 },
                 new Product {Name = "Keyboard" , Price =30000 },
                  new Product {Name = "Monitor" , Price =40000 },
                   new Product {Name = "SmartPhone" , Price =50000 },
            };

            var filterproduct = products.Where(p => p.Price > 25000);

            Console.WriteLine("Products which are greater than 500");
            foreach (var product in filterproduct) { 
                Console.WriteLine(product.Name);
            }
        }
        
    }
}
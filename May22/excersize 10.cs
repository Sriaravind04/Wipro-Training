using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Program10
    {
        static void Main() { 
            List<Product> products = new List<Product> {
                new Product{Id = 1, Name = "laptop", Price = 10000 },
                new Product{Id = 2, Name = "mobile", Price = 50000},
                new Product {Id = 3, Name = "powerbank", Price = 1000},
                new Product {Id = 4, Name = "card", Price = 20000},
                new Product {Id = 5 , Name = "watch", Price = 30000},
                new Product {Id = 6, Name = "chain", Price = 50000}
            };

            var productsList = products
                               .OrderByDescending(x => x.Price).ToList();

            foreach (var product in productsList) { 
                Console.WriteLine($"product name {product.Name} product price {product.Price}");
            }
        }
    }
}
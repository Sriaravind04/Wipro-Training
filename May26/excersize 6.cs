using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Item { 
        public string Name { get; set; }
        public string Type { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
    class Program5
    {
        static void Main() {
            List<Item> inventory = new List<Item>
            {
                new Item {Name = "Keyboard ", Type = "Electronics", Stock = 5, Price = 1200},
                new Item {Name = "Mouse", Type = "Electronics", Stock = 20, Price = 500},
                new Item {Name = "Monitor ", Type = "Electronics", Stock = 3, Price = 10000},
                   new Item {Name = "Chair ", Type = "furniture", Stock = 12, Price = 3000},
                    new Item {Name = "Desk ", Type = "furniture", Stock = 4, Price = 5500},
                     new Item {Name = "Pen", Type = "Stationary", Stock = 100, Price = 10},
                      new Item {Name = "Notebook", Type = "Stationary", Stock = 6, Price = 50},
                       new Item {Name = "USB Cable", Type = "Electroniccs", Stock = 9, Price = 150},
                        new Item {Name = "Shelf ", Type = "furniture", Stock = 7, Price = 2500},
                         new Item {Name = "Ruler", Type = "Stationary", Stock = 15, Price = 20},
                          new Item {Name = "HeadPhones", Type = "Electronics", Stock =11, Price = 2500},
                           new Item {Name = "Lamp", Type = "furniture", Stock = 2, Price =80},
                            new Item {Name = "Stapler", Type = "Stationary", Stock = 8, Price = 3200},
                             new Item {Name = "Webcam ", Type = "Electronics", Stock = 1, Price = 100},
                              new Item {Name = "Paper Ream", Type = "Stationary", Stock = 30, Price = 1200},

            };
            var lowStock = inventory.Where(i => i.Stock < 10);
            Console.WriteLine("Low stock items (Stock < 10):");
            foreach (var item in lowStock)
            {
                Console.WriteLine($"- {item.Name} ({item.Type}) | Stock: {item.Stock} | Price: Rs{item.Price}");
            }
            Console.WriteLine("\n Highest priced item in each type: ");

            var highestPricedByType = inventory
                .GroupBy(i => i.Type)
                .Select(g => g.OrderByDescending(i => i.Price).First());

            foreach (var item in highestPricedByType)
            {
                Console.WriteLine($"- {item.Type}: {item.Name} @ Rs{item.Price}");
            }
        }
    }
}
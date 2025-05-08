using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

class Product
{ 
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
class Program
{ 
    static void Main()
    {
        List<Product> products = new List<Product>
       {
           new Product { ID = 1, Name = "lAPTOP", Price = 123.22m},
           new Product { ID = 2,Name = "smartphone",Price = 111.22m },
           new Product { ID = 3,Name = "Headphone", Price=333.33m },
           new Product { ID = 4,Name="smartPhone",Price=444.44m },
           new Product { ID = 5,Name="tablet",Price=555.55m }

        };
        var SortedProducts = products.OrderByDescending(p => p.ID).ToList();

        var highestPricedProduct = SortedProducts.First();
        Console.WriteLine($"Highest pricecd product: {highestPricedProduct.Name} - ${highestPricedProduct.Price}");
    }
}
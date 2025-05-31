using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
   

    abstract class Invoice
    {
        protected List<Product> Products = new List<Product>();
        public decimal TaxRate = 0.1m;
        public decimal Discount = 0.05m;

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void CalculateTotal()
        {
            decimal subtotal = 0;
            foreach (var product in Products)
            {
                subtotal += product.Price * product.Quantity;
            }

            decimal taxAmount = subtotal * TaxRate;
            decimal discountAmount = subtotal * Discount;
            decimal total = subtotal + taxAmount - discountAmount;

            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Tax: ${taxAmount}");
            Console.WriteLine($"Discount: ${discountAmount}");
            Console.WriteLine($"Total: ${total}");
        }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    class RetailInvoice : Invoice
    {
        public void Print()
        {
            Console.WriteLine("Retail Invoice");
            Console.WriteLine("Product List:");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price} x {product.Quantity}");
            }
            CalculateTotal();
        }
    }

    class WholesaleInvoice : Invoice
    {
        public void Print()
        {
            Console.WriteLine("Wholesale Invoice");
            Console.WriteLine("Product List:");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price} x {product.Quantity}");
            }
            CalculateTotal();
        }
    }

    class Program8
    {
        static void Main()
        {
            RetailInvoice retailInvoice = new RetailInvoice();
            retailInvoice.AddProduct(new Product("Laptop", 1000, 1));
            retailInvoice.AddProduct(new Product("Mouse", 50, 2));
            retailInvoice.Print();

            Console.WriteLine();

            WholesaleInvoice wholesaleInvoice = new WholesaleInvoice();
            wholesaleInvoice.AddProduct(new Product("Monitor", 300, 5));
            wholesaleInvoice.AddProduct(new Product("Keyboard", 100, 10));
            wholesaleInvoice.Print();
        }
    }
}

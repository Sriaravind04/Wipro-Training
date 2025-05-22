using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class CartItem
    {
        public Product Item { get; set; }
        public int Quantity { get; set; }

        public double GetTotalPrice()
        {
            return Item.Price * Quantity;
        }
    }

    public class ShoppingCart
    {
        private List<CartItem> cartItems = new List<CartItem>();

        public void AddItem(Product product, int quantity)
        {
            CartItem existingItem = null;
            foreach (var cartItem in cartItems)
            {
                if (cartItem.Item.Id == product.Id)
                {
                    existingItem = cartItem;
                    break;
                }
            }

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                cartItems.Add(new CartItem { Item = product, Quantity = quantity });
            }
        }

        public void RemoveItem(int productId)
        {
            CartItem itemToRemove = null;
            foreach (var cartItem in cartItems)
            {
                if (cartItem.Item.Id == productId)
                {
                    itemToRemove = cartItem;
                    break;
                }
            }

            if (itemToRemove != null)
            {
                cartItems.Remove(itemToRemove);
            }
        }

        public double GetCartTotal()
        {
            double total = 0;
            foreach (var cartItem in cartItems)
            {
                total += cartItem.GetTotalPrice();
            }
            return total;
        }

        public void DisplayCart()
        {
            Console.WriteLine("Cart Items:");
            foreach (var cartItem in cartItems)
            {
                Console.WriteLine($"{cartItem.Item.Name} x {cartItem.Quantity} = Rs. {cartItem.GetTotalPrice()}");
            }
            Console.WriteLine($"Total Cart Value: Rs. {GetCartTotal()}");
        }
    }

    class Program14
    {
        static void Main()
        {
            Product p1 = new Product { Id = 1, Name = "Laptop", Price = 45000 };
            Product p2 = new Product { Id = 2, Name = "Mouse", Price = 500 };
            Product p3 = new Product { Id = 3, Name = "Keyboard", Price = 1000 };

            ShoppingCart cart = new ShoppingCart();

            cart.AddItem(p1, 1);
            cart.AddItem(p2, 2);
            cart.AddItem(p3, 1);

            cart.DisplayCart();

            cart.RemoveItem(2);

            Console.WriteLine("\nAfter removing Mouse:");
            cart.DisplayCart();
        }
    }
}
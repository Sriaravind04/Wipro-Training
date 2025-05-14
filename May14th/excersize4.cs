using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class FoodOrder {
        public abstract void PlaceOrder(string item);
        public void OrderInfo() { Console.WriteLine("Placing food order"); }
    }
    class FastFoodOrder : FoodOrder {
        public override void PlaceOrder(string item)
        {
            Console.WriteLine("Order Placed for " + item + " at Fast Food outlet");
        }

    }
    class FineDiningOrder : FoodOrder {
        public override void PlaceOrder(string item) { Console.WriteLine("Order Placed for " + item + " at Fine Dining Restaurant");  }
    }
    internal class Program3
    {
        static void Main(string[] args) { 
            FoodOrder fast = new FastFoodOrder();
            fast.OrderInfo();
            fast.PlaceOrder("fried rice");

            FoodOrder dining = new FineDiningOrder();
            dining.OrderInfo();
            dining.PlaceOrder("Parotta");
        }
    }
}
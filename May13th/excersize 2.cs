using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//excersize 2 Interface - Restauranat Order Management

namespace ConsoleApp4
{
    public interface IOrder {
        void PlaceOrder(string item);
        void CancelOrder(string item);
    }
    public class DineInorder : IOrder {
        public void PlaceOrder(string item)
        {
            Console.WriteLine("Placing dine in order for "+item);
        }
        public void CancelOrder(string item) {
            Console.WriteLine("Canceling dine-in order for "+item);
        }
    }
    public class TakeawayOrder : IOrder {
        public void PlaceOrder(string item) {
            Console.WriteLine("Placing takeaway order for "+item);
        }
        public void CancelOrder(string item) {
            Console.WriteLine("canceling takeaway order for "+item);
        }
    }
    internal class Program11
    {
        static void Main(string[] args) { 
            IOrder order = new TakeawayOrder();
            order.PlaceOrder("pizza");
            order.CancelOrder("pizza");

            IOrder order2 = new TakeawayOrder();
            order2.PlaceOrder("burger");
            order2.CancelOrder("burger");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class PaymentMethod {
        public abstract void Processpayment(decimal amount);
        public void ShowPaymentMethod(string method) {
            Console.WriteLine($"Payment Method: {method}");
        }
    }
    class CreditCardPayment : PaymentMethod {
        public override void Processpayment(decimal amount) {
            Console.WriteLine($"Processing credit card payment of Rs{amount}");
        }
    }
    class UPIPayment : PaymentMethod {
        public override void Processpayment(decimal amount) {
            Console.WriteLine($"Processing UPI payment of Rs{amount}");
        }
    }
    class Program3
    {
        static void Main(string[] args) { 
            CreditCardPayment card = new CreditCardPayment();
            card.ShowPaymentMethod("card");
            card.Processpayment(1000);

            UPIPayment upi = new UPIPayment();
            upi.ShowPaymentMethod("upi");
            upi.Processpayment(2000);

            Console.WriteLine("Polymorphism");

            List<PaymentMethod> list = new List<PaymentMethod> { card, upi };
            foreach (var payment in list) { 
               payment.Processpayment(3000);
            }
            

        }
    }
}
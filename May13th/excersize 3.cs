using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class PaymentGateway {
        public abstract void ProcessPayment(double amount);
        public void ShowGatewayName() {
            Console.WriteLine("Processing payment through gateway");
        }
    }
    public class StripeGateway : PaymentGateway {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment through stripe: Rs{amount}");
        }
    }
    public class PayPalGateway : PaymentGateway {
        public override void ProcessPayment(double amount) {
            Console.WriteLine($"Processing payment through PayPal: Rs{amount}");
        }

    }
    class Program13
    {
        static void Main(string[] args) {
            PaymentGateway payment = new StripeGateway();
            payment.ShowGatewayName();
            payment.ProcessPayment(1500.00);

            PaymentGateway payment2 = new PayPalGateway();
            payment2.ShowGatewayName();
            payment2.ProcessPayment(2500);
        }
    }
}

using System;

interface IPaymentProcessor {
    public void ProcessPayment(double amount);

}
abstract class PaymentGateway 
{
    public string GatewayName {  get; set; }

    public PaymentGateway(string name)
    {
        GatewayName = name;
    }
    public virtual bool Validate() {
        Console.WriteLine($"Validating {GatewayName} gateway...");
        return true;
    }
}

class Razorpay : PaymentGateway, IPaymentProcessor
{
    public Razorpay() : base("Razorpay") { }

    public void ProcessPayment(double amount)
    {
        if (Validate())
            Console.WriteLine($"PRocessed Rs{amount} using {GatewayName}");
    }


}

class PayPal : PaymentGateway, IPaymentProcessor
{
    public PayPal() : base("PayPal") { }

    public void ProcessPayment(double amount)
    {
        if (Validate())
            Console.WriteLine($"PRocessed Rs{amount} using {GatewayName}");
    }


}

class Stripe : PaymentGateway, IPaymentProcessor
{
    public Stripe() : base("Stripe") { }

    public void ProcessPayment(double amount) {
        if(Validate())
            Console.WriteLine($"Processed Rs{amount} using {GatewayName}");
    }
}
class Program
{
    static void Main()
    {
        List<IPaymentProcessor> payments = new List<IPaymentProcessor>
        {
            new Razorpay(),
            new PayPal(),
            new Stripe()
        };

        double[] amounts = { 500.0, 1200.5, 999.9 };

        for (int i = 0; i < payments.Count; i++)
        {
            payments[i].ProcessPayment(amounts[i]);
        }
    }
}
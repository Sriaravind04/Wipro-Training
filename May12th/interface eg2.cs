using System;

interface IPayment
{
    void ProcessPayment(decimal amount);

}

//Implementing the inteface in CreditCardPayment

class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ₹{amount}");
    }
}

//Implementing the interface in paypalpayment

class PayPayPayment : IPayment 
{
    public void ProcessPayment(decimal amount) {
        Console.WriteLine($"Processing Paypal payment of ₹{amount}");
    }
}

class Program
{
    static void Main()
    {
        //using the interface as a reference
        IPayment payment;

        //Credit card Payment
        payment = new CreditCardPayment();
        payment.ProcessPayment(1500.50m);

        //Paypal payment
        payment = new PayPayPayment();
        payment.ProcessPayment(2500.75m);
    }


}
using System;

class Payment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Paying " + amount + " USD");
    }

    public void ProcessPayment(decimal amount, string currency)
    {
        Console.WriteLine("Paying " + amount + " " + currency);
    }
}

class CreditCard : Payment
{
    public string CardNumber;
}

class PayPal : Payment
{
    public string Email;
}

class Program
{
    static void Main()
    {
        CreditCard cc = new CreditCard();
        cc.CardNumber = "1234-5678";
        cc.ProcessPayment(100);

        PayPal pp = new PayPal();
        pp.Email = "user@mail.com";
        pp.ProcessPayment(50, "EUR");
    }
}
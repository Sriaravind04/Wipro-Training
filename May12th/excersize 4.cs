using System;

abstract class Notification {
    public abstract void Send();
    public void ShowType() {
        Console.WriteLine("Sending Notification");
    }
}

class EmailNotification : Notification {
    public override void Send() {
        Console.WriteLine("Sending Email");
    }
}

class SMSNotification : Notification {
    public override void Send() { Console.WriteLine("Sending SMS Notification"); }
}
class Program
{
    static void Main() { 
        Notification email = new EmailNotification();
        Notification sms = new SMSNotification();

        email.Send();
        email.ShowType();

        sms.Send();
        sms.ShowType();
    }
}
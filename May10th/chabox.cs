using System;

class ChatBot
{
    public void Respond(string message)
    {
        Console.WriteLine("You said: " + message);
    }

    public void Respond(string question, bool formal)
    {
        if (formal)
            Console.WriteLine("Formal reply to: " + question);
        else
            Console.WriteLine("Casual reply to: " + question);
    }

    public void Respond(int number)
    {
        Console.WriteLine("You gave number: " + number);
    }
}

class Program
{
    static void Main()
    {
        ChatBot bot = new ChatBot();
        bot.Respond("Hi!");
        bot.Respond("What's the time?", false);
        bot.Respond(100);
    }
}
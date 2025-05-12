using System;

interface IAnimalActions
{
    void Eat();
    void Sleep();
}

class Lion : IAnimalActions
{
    public void Eat() {
        Console.WriteLine("Lion is eating meat");
    }
    public void Sleep()
    {
        Console.WriteLine("Lion is sleeping");
    }
}

class Elephant : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Elephant is eating grass");
    }
    public void Sleep() {
        Console.WriteLine("Elephant is sleeping");
    }
}

class Program
{
    static void Main() { 
        IAnimalActions king = new Lion();
        IAnimalActions general = new Elephant();

        king.Eat();
        king.Sleep();

        general.Sleep();
        general.Eat();
    }
}
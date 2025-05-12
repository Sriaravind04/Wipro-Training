using System;

abstract class Shape
{
    public abstract void Draw(); //Abstract method

    public void Display()
        {
        Console.WriteLine("THIS IS A shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}
class Program
{
    static void Main()
    { 
        Circle circle = new Circle();
        circle.Draw();
    }
}
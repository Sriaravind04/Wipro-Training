using System;
interface IShape
{
    void Draw();
}

class Circle : IShape
{ 
    public void Draw()
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
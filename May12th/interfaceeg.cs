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
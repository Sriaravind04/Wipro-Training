using System;

class AreaCalculator
{
    public double Area(double length, double breadth)
    {
        return length * breadth; 
    }

    public double AreaCircle(double radius)
    {
        return Math.PI * radius * radius; 
    }

    public double AreaTriangle(double baseLength, double height)
    {
        return 0.5 * baseLength * height; 
    }
}

class Program
{
    static void Main()
    {
        AreaCalculator ac = new AreaCalculator();

        Console.WriteLine("Area of Rectangle: " + ac.Area(5, 3));
        Console.WriteLine("Area of Circle: " + ac.AreaCircle(4));
        Console.WriteLine("Area of Triangle: " + ac.AreaTriangle(4, 6));
    }
}
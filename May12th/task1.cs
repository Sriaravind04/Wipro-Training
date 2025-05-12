using System;

interface ICalculator
{ 
    int Add(int a,int b);
    int  Subtract(int a,int b);
    int  Multiply(int a,int b);
    int Divide(int a,int b);
}

class SimpleCalculator : ICalculator
{
    public int Add(int a, int b) { 
        return a + b;
    }
    public int Subtract(int a, int b) { 
        return a - b;
    }
    public int Multiply(int a, int b) {
        return a * b;
    }
    public int Divide(int a, int b) {
        return a / b;
    }
}

class Program
{
    static void Main()
    { 
        ICalculator calculator = new SimpleCalculator();
       Console.WriteLine( "add : "+calculator.Add(1, 2));
        Console.WriteLine("subtract: "+calculator.Subtract(1, 2));
        Console.WriteLine("multiply: "+calculator.Multiply(1, 2));
        Console.WriteLine("divide: "+calculator.Divide(1, 2));
    }
}

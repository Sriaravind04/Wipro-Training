using System;

interface ICalculator
{ 
    void Add(int a,int b);
    void Subtract(int a,int b);
    void Multiply(int a,int b);
    void Divide(int a,int b);
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
        calculator.Add(1, 2);
        calculator.Subtract(1, 2);
        calculator.Multiply(1, 2);
        calculator.Divide(1, 2);
    }
}

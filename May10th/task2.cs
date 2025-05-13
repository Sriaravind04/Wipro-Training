using System;


class PowerCalculater
{
    public int Power (int basenum, int exponent) 
    {
        return (int)Math.Pow(basenum, exponent);
    }
    public double Power (double basenum, double exponent)
    {
        return Math.Pow(basenum, exponent);
    }
}

class Program
{
    static void Main()
    {
        PowerCalculater pc = new PowerCalculater();
        Console.WriteLine("2^3= " + pc.Power(2, 3));
        Console.WriteLine("5.5^2= " + pc.Power(5.5,2));
    }
}
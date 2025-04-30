using System;

public class HelloWorld
{
    static int Add(int a , int b) => a +b;
    static int Subtract(int a,int b) => a-b;
    static int Multiply(int a, int b) => a* b;
    static double Divide(int a,int b) => (b==0) ? 0: a/b;
      
    static void Main() {
        Console.WriteLine("Add: " +Add(10,4));
        Console.WriteLine("Subtract: " +Subtract(10,5));
        Console.WriteLine("Multiply: " +Multiply(10,5));
        Console.WriteLine("Divide: " +Divide(10,5));
    }
}
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a = 123;
        int b =0;
        
        while(a>0) {
            int digit = a%10;
            b = b*10 + digit;
            a /= 10;
        }
        Console.WriteLine("reversed no: "+b);
    }
}
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a =12;
        int b = 0;
        while(a>0) {
            int digit = a%10;
            b += digit;
            a /= 10;
           
        }
         Console.WriteLine(b);
        
      
    }
       
}
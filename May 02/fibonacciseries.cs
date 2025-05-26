using System;

public class HelloWorld
{
    static long fibonacci(int n) 
    {
        if(n<=1){
            return n;
        }
        return fibonacci(n-1) + fibonacci(n-2);
    }
    
    static void Main() 
    {
        int count = 10;
        Console.WriteLine($"First {count} Fibonacci numbers (using recursion):");
        for(int i=0;i<count;i++) {
            Console.Write(fibonacci(i) +" " );
        }
    }
   
}

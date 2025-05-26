using System;

public class HelloWorld
{
    static int countzeros(int n) 
    {
        if(n==0) {
            return 1;
        }
        else if(n<10) {
            return n==0 ? 1 : 0;
        }
        else {
            int lastdigit = n%10;
            int count = (lastdigit == 0 ) ? 1:0;
            return count + countzeros(n/10);
        }
    }
    static void Main() 
    {
        int n = 1020400;
        int result = countzeros(n);
        Console.WriteLine($"Number of zeros in {n} is: {result}");
    }
}

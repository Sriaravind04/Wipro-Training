using System;

public class HelloWorld
{

public class Program {
    // Recursive function to sum digits
    static int SumOfDigits(int n) {
        if (n == 0)
            return 0;
        return (n % 10) + SumOfDigits(n / 10);
    }

    static void Main() {
        int number = 1234;  // You can change this to any number
        int result = SumOfDigits(number);
        Console.WriteLine($"Sum of digits of {number} is: {result}");
    }
}
   
}
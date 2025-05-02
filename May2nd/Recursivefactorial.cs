using System;

public class HelloWorld
{
public class Program {
    // Recursive method to find factorial
    static long Factorial(int n) {
        if (n <= 1)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main() {
        int number = 7;
        long result = Factorial(number);
        Console.WriteLine($"Factorial of {number} is: {result}");
    }
}
}

using System;

public class DigitSum {
    public static int SumOfDigits(int number) { 
        
        int sum = 0;

        while (number > 0)
        {
            int temp = number % 10;
            sum += temp;
            number /= 10;
        }
        return sum;

    }
    public static void Main() {
        int number = 1234;
        int sum = SumOfDigits(number);
        Console.WriteLine(sum);
        
    }
}
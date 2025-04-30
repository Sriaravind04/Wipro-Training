using System;

public class HelloWorld
{
    static int FindMax(int[] numbers)
    {
        int max = numbers[0];
        for(int i =1;i<numbers.Length;i++) {
            if(numbers[i]>max) 
            max = numbers[i];
            
        }
        return max;
    }
    static void Main()
    {
        int[] numbers = { 45,56,67,89,23,90};
        Console.WriteLine("answer is : " +FindMax(numbers));
    }
}
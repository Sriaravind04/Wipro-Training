using System;

public class HelloWorld
{

public class Program {
    // Recursive function to print elements
    static void PrintArray(int[] arr, int index) {
        if (index >= arr.Length)
            return;

        Console.WriteLine(arr[index]);
        PrintArray(arr, index + 1);
    }

    static void Main() {
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Array elements printed recursively:");
        PrintArray(numbers, 2); 
    }
}
}
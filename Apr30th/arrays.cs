using System;

public class HelloWorld
{
    static void PrintArray(int[] arr) {
        for(int i=0; i< arr.Length;i++) {
            Console.WriteLine($"Element {i+1}: {arr[i]}");
        }
    }
    static void Main() {
        int[] numbers = {10,20,30,40,50};
        PrintArray(numbers);
    }
}
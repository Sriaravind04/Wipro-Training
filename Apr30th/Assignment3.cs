using System;

public class HelloWorld
{
    static void PrintArray(int[] numbers)
    {
        // Create an array to hold the unique elements
        int n = numbers.Length;
        int[] uniqueNumbers = new int[n];
        int uniqueCount = 0;

        // Add unique elements to the uniqueNumbers array
        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < uniqueCount; j++)
            {
                if (numbers[i] == uniqueNumbers[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                uniqueNumbers[uniqueCount] = numbers[i];
                uniqueCount++;
            }
        }

        // Print the unique elements as an array
        Console.Write("[");

        for (int i = 0; i < uniqueCount; i++)
        {
            Console.Write(uniqueNumbers[i]);
            if (i < uniqueCount - 1) // To avoid trailing comma
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("]");
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 1, 3, 2, 1, 4, 4, 4 };
        PrintArray(numbers);
    }
}
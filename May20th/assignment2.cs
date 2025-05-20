using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class SearchAlgorithms
    {
        // Linear Search
        public static (int, int) LinearSearch(int[] arr, int key)
        {
            int comparisons = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                comparisons++;
                if (arr[i] == key)
                {
                    return (i, comparisons);
                }
            }
            return (-1, comparisons);
        }

        // Binary Search 
        public static (int, int) BinarySearch(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;
            int comparisons = 0;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                comparisons++;

                if (arr[mid] == key)
                {
                    return (mid, comparisons);
                }
                else if (arr[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return (-1, comparisons);
        }

        public static int[] GenerateSortedArray(int size, int min, int max)
        {
            Random rand = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(min, max + 1);
            }

            Array.Sort(arr);
            return arr;
        }
        class Program1 {
            public static void Main()
            {
                // Generate a sorted array of 50 integers between 1 and 200
                int[] sortedArray = GenerateSortedArray(50, 1, 200);

                // Display the sorted array
                Console.WriteLine("Sorted Array:");
                Console.WriteLine(string.Join(", ", sortedArray));

                // Randomly select an element to search for
                Random rand = new Random();
                int element = sortedArray[rand.Next(sortedArray.Length)];

                Console.WriteLine($"\nSearching for element: {element}");

                // Linear Search
                var (linearPosition, linearComparisons) = LinearSearch(sortedArray, element);
                Console.WriteLine("\nLinear Search:");
                Console.WriteLine($"Position: {linearPosition}, Comparisons: {linearComparisons}");

                // Binary Search
                var (binaryPosition, binaryComparisons) = BinarySearch(sortedArray, element);
                Console.WriteLine("\nBinary Search:");
                Console.WriteLine($"Position: {binaryPosition}, Comparisons: {binaryComparisons}");
            }
        }
    }
   
}
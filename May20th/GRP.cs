using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    
    class GraphAlgorithm
    {
        class SearchResult
        {
            public int Position;
            public int Comparisons;
        }
        static void Main() {
            int[] arr = GenerateSortedArray(50);
            Random rand = new Random();
            int key = rand.Next(1, 201);

            Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
            Console.WriteLine("Searching for: " + key);

            SearchResult linear = LinearSearch(arr, key);
            Console.WriteLine($"\nLinear Search -> Position: {linear.Position}, Comparisons: {linear.Comparisons}");

            SearchResult binary = BinarySearch(arr, key);
            Console.WriteLine($"Binary Search -> Position: {binary.Position}, Comparisons: {binary.Comparisons}");

            
        }
        static SearchResult LinearSearch(int[] arr, int key) { 
            SearchResult result = new SearchResult();
            result.Position = -1;

            for (int i = 0; i < arr.Length; i++) {
                result.Comparisons++;
                if (arr[i] == key) {
                    result.Position = i;
                    break;
                }
            }
            return result;
        }
        static SearchResult BinarySearch(int[] arr, int key) {
            SearchResult result = new SearchResult();   
            result.Position = -1;

            int left = 0,right = arr.Length - 1;
            while (left <= right) {
                result.Comparisons++;
                int mid = (left + right) / 2;
                if (arr[mid] == key)
                {
                    resu
                }
            }
        }
    }
}
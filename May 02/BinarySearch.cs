using System;

public class HelloWorld
{
    //Binary Search
    static int BinarySearch(int[] arr, int target)
    {
       int low =0;
       int high = arr.Length -1;
       
       while (low<=high)
       {
           int mid = (low+high)/2;
           if(arr[mid] == target) 
            return mid;
           else if(arr[mid]< target)
            low = mid +1;
           else
            high = mid -1;
       }
       return -1;
    }
    static void Main() 
    {
        int[] numbers = {10,20,30,40,50,60,70};
        int target = 40;
        
        int result = BinarySearch(numbers,target);
        
        if(result != -1)
            Console.WriteLine($"Element {target} found at index {result}");
        else
            Console.WriteLine($"Element {target} not found in the array");
    }
}

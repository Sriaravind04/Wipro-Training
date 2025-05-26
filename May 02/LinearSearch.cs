using System;

public class HelloWorld
{
   
        //Linear Search Method
        static int LinearSearch(int[] arr,int target) {
            for(int i=0; i<arr.Length;i++) {
                if(arr[i]==target)
                return i; //Return index where target is found
            }
            return -1; //not found
        }
    
    
    static void Main()
    {
        int[] numbers = {10,25,30,45,60,75};
        int target = 45;
        
        int result = LinearSearch(numbers,target);
        
        if(result != -1) 
            Console.WriteLine($"Element {target} found at index {result}");
        else 
            Console.WriteLine($"Element {target} not found in the array");
    }
}
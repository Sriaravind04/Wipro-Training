using System;

public class HelloWorld
{
    static void FindPairsWithSum(int[] arr,int target) 
    {
        for(int i=0;i<arr.Length;i++) 
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i] + arr[j] == target)
                {
                    Console.WriteLine($"{arr[i]} + {arr[j]} = {target}");
                }
            }
        }
    }
    static void Main()
    {
        int[] numbers = {2,4,3,5,7};
        int targetSum =9;
        
        FindPairsWithSum(numbers, targetSum);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

class Program
{ 
    static void Main()
    {
        //excersize 2
        ArrayList nums = new ArrayList {1,2,3,4,5,6,7,8,9,10};

        nums.Sort();
        int max = (int)nums[nums.Count - 1];

        Console.WriteLine("max value: " +max);
        Console.WriteLine("min value: " + nums[0]);
        int avg=0;
        foreach(int num in nums) 
        {
           avg=avg + num;
        }
        int average = avg / nums.Count;
        Console.WriteLine("average is : " + average);

    }
}
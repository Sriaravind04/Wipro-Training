using System;
class Program
{
    static int largest(int[] arr, int index, int l, int secondlarge)
    {
        if (index == arr.Length) return secondlarge;
        int curr = arr[index];
        if (curr > l)
        {
            secondlarge = l;
            l= curr;

        }
        else if (curr > secondlarge && curr != l)
        {
            secondlarge = curr;

        }
        return largest(arr, index, l, secondlarge);
    }
    static void Main()
    {
        int[] num = { 10,25,30,5,60 };
        int secondlarge = largest(num, 0, int.MinValue, int.MinValue);
        Console.WriteLine(secondlarge);
    }
}
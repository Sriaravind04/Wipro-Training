using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

class Program
{ 
    static void Main()
    {
       List<int> unique = new List<int> { 1,2,2,32,4,4,5,6,7,77};

        HashSet<int> unique2 = new HashSet<int>(unique);

        foreach (int i in unique2) { 
            Console.WriteLine(i);
        }

        Console.WriteLine("total unique elements are :"+unique2.Count);
    }
}
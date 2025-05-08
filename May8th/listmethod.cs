using System;
using System.Collections.Generic;
class Program
{ 
    static void Main()
    {
        List<string> fruits = new List<string>() { "avacado", "banana" };

        //Adding an element
        fruits.Add("Mango");

        //Inserting an element at index
        fruits.Insert(1, "orange");

        //Removing an element by index
        fruits.RemoveAt(2);

        //Checking if an element exists
        if (fruits.Contains("Apple"))
            Console.WriteLine("apple is in the list");

        //sortng the list
        fruits.Sort();

        //Printing the final list
        Console.WriteLine("Fruits List:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{ 
    static void Main()
    {
        Dictionary<string, string> cities = new Dictionary<string, string>
     {
         { "mumbai", "maharastra"},
         { "Bangalore", "karnataka"},
         { "kolkata", "West Bengal"},
         { "chennai","Tamilnadu"},
         { "Hyderabad","Telagana"}
     };
        Console.WriteLine("Indian Cities and their States:");
        foreach (var city in cities)
        {
            Console.WriteLine($"{city.Key} is  in {city.Value}");
        }

        //check if a specific city exist
        if (cities.ContainsKey("chennai"))
        {
            Console.WriteLine("Chennai is present in the dictionary.");
        }
    }
}


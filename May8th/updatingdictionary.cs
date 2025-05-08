using System;
using System.Collections.Generic;

class Program
{ 
    static void Main()
    {
      Dictionary<int, string> employees = new Dictionary<int, string>

        {
            {1,"Rohit" },
            {2,"Anjali" },
            { 3,"Sandep"}
        };

        //updating the name for employee id 2
        employees[2] = "ananya";

        Console.WriteLine("Updated employee list: ");
        foreach (var emp in employees) {
            Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
        }
   
    }
}
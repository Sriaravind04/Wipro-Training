using System;
using System.Collections.Generic;


class Program
{ 
    static void Main()
    {
        //Createing a dictionary to store student IDS and names
      Dictionary<int, string> students = new Dictionary<int, string>();

        //adding element
        students.Add(101, "alice");
        students.Add(102, "bob");
        students.Add(103, " Charlie");

        //Accessing values using keys
        Console.WriteLine("Student with ID 102: " + students[102]);

        //Looping through the dictionary
        foreach (var pair in students) {
            Console.WriteLine($"ID: {pair.Key},Name: {pair.Value}");
        }
   
    }
}
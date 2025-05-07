using System;
using System.Collections;
class Program
{
    static void Main() {
        ArrayList Students = new ArrayList() {"abinash","karthick","suriya","vijay","ajith"};
        if (Students.Contains("ajith"))
        {
            Console.WriteLine("found");
        }
        else {
            Console.WriteLine("not found");
        }
        Students.RemoveAt(1);
        foreach (var student in Students)
        {
            Console.WriteLine(student);
        }
    }
}
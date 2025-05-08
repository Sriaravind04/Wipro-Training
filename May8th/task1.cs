using System;
using System.Collections;
using System.Collections.Generic;

class Program
{ 
    static void Main()
    {
        //  EXERCISE 1
        //MANAGE STUDENT NAMES

        ArrayList students = new ArrayList();
        students.Add("ashok");
        students.Add("murugan");
        students.Add("lourdes");
        students.Add("tharun");
        students.Add("aravind");

        students.RemoveAt(3);

        foreach (var student in students) { 
            Console.WriteLine(student);
        }

        if (students.Contains("aravind"))
        {
            Console.WriteLine("found");
        }
        else {
            Console.WriteLine("notfound");
        }
    }
}
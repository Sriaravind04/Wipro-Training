using System;
using System.Collections.Generic;

class employee {
    public int ID { get; set; }
public string Name { get; set; }
    }
class Program
{ 
    static void Main()
    {
        List<employee> employees = new List<employee>();

        employees.Add(new employee { ID = 1, Name = "ashok" });
        employees.Add(new employee { ID = 2, Name = "alan" });
        employees.Add(new employee { ID = 3, Name = "karthick" });
        employees.Add(new employee { ID = 4, Name = "vel" });
        employees.Add(new employee { ID = 5, Name = "dhoni" });

        employees.RemoveAll(e => e.Name == "alan");

        if (employees.Any(e => e.Name.Contains("vel"))) {
            Console.WriteLine("found");
        }
        else
        {
            Console.WriteLine("not found");

        }

        foreach (employee e in employees) { 
            Console.WriteLine(e.Name);
        }
   
    }
}
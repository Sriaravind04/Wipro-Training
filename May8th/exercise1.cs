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

        new employee { ID = 1, Name = "ashok" };
        new employee { ID = 2, Name = "alan" };
        new employee { ID = 3, Name = "karthick" };
        new employee { ID = 4, Name = "vel" };
        new employee { ID = 5, Name = "dhoni" };

        employees.Remove("alan");
    }
}
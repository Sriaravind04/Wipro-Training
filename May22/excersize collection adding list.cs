using System;
using System.ComponentModel;
using System.Collections;

class Program {
    static void Main(string[] args) {
        List<string> students = new List<string> { "aravind", "sri", "sam", "jeffery", "jenish"};

        foreach (var student in students) {
            Console.WriteLine(student);
        }
        Console.WriteLine("-----------------Sorting------------");
        students.Sort();
        foreach (var student in students) { 
            Console.WriteLine(student);
        }

    }
}
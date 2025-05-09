using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class student
    {
        public int RollNumber;
        public string Name;
        public int Marks;

        public void PrintDetails()
        {
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Marks: {Marks}");
        }
    }
}

using System;
using ConsoleApp2;


class Program
{ 
    static void Main()
    {
        
        student student1 = new student { RollNumber = 101, Name = "Neha", Marks = 90};
          student student2 = new student { RollNumber = 102, Name = "Ravi", Marks = 75};

          student1.PrintDetails();
          student2.PrintDetails();
    }
}
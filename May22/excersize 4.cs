using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Student {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    class Program4
    {
        static void Main(string[] args) { 
            List<Student> students = new List<Student> {
                new Student {Name = "aravind", Marks = 99},
                new Student {Name = "sam", Marks = 80},
                new Student {Name = "jeffery", Marks = 90},
                new Student {Name = "jenish", Marks = 95},
                new Student {Name = "yeswant", Marks = 70},
                new Student {Name = "prabhu", Marks = 71}
            };


            var topstudents = students
                              .OrderByDescending(x => x.Marks)
                              .Take(3)
                              .ToList();

            foreach (var student in topstudents) { 
                Console.WriteLine($"Name = {student.Name}, Marks = {student.Marks}");
            }
        }
    }
}
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
    class Program9
    {
        static void Main()
        {
            List<Student> students = new List<Student> {
            new Student {Name = "sri", Marks = 80},
            new Student {Name = "ashok", Marks = 88},
            new Student {Name = "madhu", Marks = 77},
            new Student {Name = "lourdes", Marks = 76},
            new Student {Name = "sam", Marks = 99}
        };

            var average = students.Average(x => x.Marks);
            Console.WriteLine("Average Marks: "+average);

            var aboveaverage = students.Where(x => x.Marks > average).ToList();
            Console.WriteLine("above average students are");
            foreach (Student stu in aboveaverage) {
                Console.WriteLine(stu.Name);
            }
                        

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
    }

    class Program1
    {
        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student { Name = "John", Marks = 85, Grade = "A" },
            new Student { Name = "Glen", Marks = 89, Grade = "A" },
            new Student { Name = "Paul", Marks = 75, Grade = "B" },
            new Student { Name = "Rajiv", Marks = 95, Grade = "A" },
            new Student { Name = "Aditya", Marks = 88, Grade = "A" },
            new Student { Name = "Midun", Marks = 65, Grade = "C" },
            new Student { Name = "Thomas", Marks = 74, Grade = "B" },
            new Student { Name = "Julia", Marks = 66, Grade = "C" },
            new Student { Name = "Tim", Marks = 57, Grade = "D" },
            new Student { Name = "Phil", Marks = 92, Grade = "A" },
        };

            // Sort by marks in descending order
            var sortedByMarks = from student in students
                                orderby student.Marks descending
                                select student;

            Console.WriteLine("Sorted Students by Marks (Descending):");
            foreach (var student in sortedByMarks)
            {
                Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}, Grade: {student.Grade}");
            }
            Console.WriteLine();

            // Group by grade
            var groupedByGrade = from student in sortedByMarks
                                 group student by student.Grade into gradeGroup
                                 select gradeGroup;

            Console.WriteLine("Grouped by Grade:");
            foreach (var group in groupedByGrade)
            {
                Console.WriteLine($"Grade: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"  Name: {student.Name}, Marks: {student.Marks}");
                }
            }
            Console.WriteLine();

            // top 3 students per grade
            var top3GroupedByGrade = from gradeGroup in groupedByGrade
                                     select new
                                     { Grade = gradeGroup.Key, TopStudents = gradeGroup.Take(3) };

            Console.WriteLine("Top 3 Students per Grade:");
            foreach (var group in top3GroupedByGrade)
            {
                Console.WriteLine($"Grade: {group.Grade}");
                foreach (var student in group.TopStudents)
                {
                    Console.WriteLine($"  Name: {student.Name}, Marks: {student.Marks}");
                }
            }
        }
    }
   
}
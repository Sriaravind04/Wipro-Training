using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Student
    {
  
        public string Name { get; set; }
        public Dictionary<string, int> Marks { get; set; }

        public double Average => Marks.Values.Average();
        public int Highest => Marks.Values.Max();
        public int Lowest => Marks.Values.Min();
        public int Total => Marks.Values.Sum();

        public Student(string name)
        { 
            Name = name;
            Marks = new Dictionary<string, int>();
        }
    }

    class Program10
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            Student s1 = new Student("Alice");
            s1.Marks["Math"] = 85;
            s1.Marks["Science"] = 90;
            s1.Marks["English"] = 78;

            Student s2 = new Student("Charlie");
            s2.Marks["Math"] = 92;
            s2.Marks["Science"] = 88;
            s2.Marks["English"] = 91;

            Student s3 = new Student("sri");
            s3.Marks["Math"] = 70;
            s3.Marks["Science"] = 68;
            s3.Marks["English"] = 65;

            Student s4 = new Student("aravind");
            s4.Marks["Math"] = 95;
            s4.Marks["Science"] = 98;
            s4.Marks["English"] = 94;


            Console.WriteLine("Student Report:");
            foreach (var student in students)
            {
                Console.WriteLine($"\nName: {student.Name}");
                Console.WriteLine($"Total: {student.Total}");
                Console.WriteLine($"Average: {student.Average}");
                Console.WriteLine($"Highest: {student.Highest}");
                Console.WriteLine($"Lowest: {student.Lowest}");
            }

            var top3 = students.OrderByDescending(s => s.Total).Take(3);

            Console.WriteLine("\nTop 3 Scores: ");

            foreach (var student in top3)
            {
                Console.WriteLine($"{student.Name} - Total: {student.Total}");
            }
        }
    }
}

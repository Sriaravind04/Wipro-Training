using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Employee {
        public string Name { get; set; }
        public string Department {  get; set; }
    }
    class Program5
    {
        static void Main() { 
            List<Employee> list = new List<Employee> {
                new Employee {Name = "sri", Department = "EEE"},
                new Employee {Name = "aravind", Department = "EEE"},
                new Employee {Name = "ashok", Department = "CSE"},
                new Employee {Name = "Lourdes", Department = "CSE"},
                new Employee {Name = "Madhu", Department = "MECH"},
                new Employee {Name = "thanigavel", Department = "MECH"}
            };

            var groupedByDepartment = list
                                      .GroupBy(x => x.Department);

            foreach (var group in groupedByDepartment) { 
                Console.WriteLine($"\nDepartemnt: {group.Key}");
                foreach (var emp in group) { 
                    Console.WriteLine($" - {emp.Name}");
                }
            }
        }
    }
}
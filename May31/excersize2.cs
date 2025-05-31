using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
    class Program2
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1,Name="sri",Department="EEE",Salary= 25000 },
            new Employee { ID = 3, Name = "aravind", Department = "Mech", Salary = 28000 },
            new Employee { ID = 4, Name = "lourdes", Department = "CSE", Salary = 32000 },
            new Employee { ID = 5, Name = "Logesh", Department = "ECE", Salary = 35000 },
            new Employee { ID = 6, Name = "sam", Department = "EEE", Salary = 27000 }
        };
            var departmentgroup = from emp in employees
                                  group emp by emp.Department into g
                                  select g;

            var descendingsalary = from g in departmentgroup
                                   select new
                                   {
                                       Department = g.Key,
                                       Employees = g.OrderByDescending(emp => emp.Salary)
                                   };
            foreach (var emp in descendingsalary)
            {
                Console.WriteLine(emp.Department);
                foreach (var employee in emp.Employees)
                {
                    Console.WriteLine(employee.ID + " " + employee.Name + " " + employee.Salary);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            var averagesalary = from g in departmentgroup
                                select new
                                {
                                    Department = g.Key,
                                    Employees = g.Average(emp => emp.Salary)
                                };
            foreach (var emp in averagesalary)
            {
                Console.WriteLine("Department Name: " + emp.Department);
                Console.WriteLine("Average salaer: " + emp.Employees);
                Console.WriteLine();
            }
        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmployeeArray = { 
                new Employee() { EmployeeID = 1,EmployeeName = "John",Age = 18},
                new Employee() { EmployeeID = 2,EmployeeName = "Steve",Age = 21 },
                new Employee() { EmployeeID = 3,EmployeeName = "Bill",Age=25 },
                new Employee() { EmployeeID = 4,EmployeeName = "Ram", Age=20 },
                new Employee() { EmployeeID = 5,EmployeeName = "Ron", Age = 31 },
                new Employee() { EmployeeID = 6,EmployeeName = "Chris", Age = 17 },
                new Employee() { EmployeeID = 7,EmployeeName = "Rob", Age = 19 },
            };
            Employee[] Employees = new Employee[10];

            int i = 0;

            foreach (Employee employee in EmployeeArray) {
                if (employee.Age > 12 && employee.Age < 20)
                {
                    Employees[i] = employee;
                    System.Console.WriteLine(employee.EmployeeName);
                    i++;
                }
                }
        }
    }
}
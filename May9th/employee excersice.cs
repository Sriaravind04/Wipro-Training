using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public int Salary;

        public void PrintDetails() {
            Console.WriteLine($"EmployeeID: {EmployeeID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salry: {Salary}");
        }
        public void UpdateSalary(double newsalary) {
            Salary = (int)newsalary;
            Console.WriteLine($"new Salary: {newsalary}");
        }
        public void AnnualSalary() {
            int income = Salary * 12;
            Console.WriteLine($"annual salary: {income}");
        }
    }
}



using System;
using ConsoleApp2;


class Program
{ 
    static void Main()
    {
        
        Employee emp1 = new Employee { EmployeeID = 1, Name = "arun", Department = "EEE", Salary = 1000 };
        emp1.PrintDetails();
        emp1.UpdateSalary(2000);
        emp1.AnnualSalary();
    }
}
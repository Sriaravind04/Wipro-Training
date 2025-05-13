using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Employee {
        public abstract void CalculateSalary();
        public void ShowBasicInfo() {
            Console.WriteLine("Employee details");
        }
    }
    public class FullTimeEmployee : Employee {
        public override void CalculateSalary() {
            Console.WriteLine("salary: Basic + allowance");
        }
    }
    public class PartTimeEmployee : Employee {
        public override void CalculateSalary() {
            Console.WriteLine("Salary: Hourlyrate x Hours worked");
        }
    }
    internal class Program14
    {
        static void Main(string[] args) { 
            Employee e = new FullTimeEmployee();
            e.CalculateSalary();
            e.ShowBasicInfo();

            Employee e2 = new PartTimeEmployee();
            e2.CalculateSalary();
            e2.ShowBasicInfo();
        }
    }
}
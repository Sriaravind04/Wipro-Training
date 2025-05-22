using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    interface IAttendence
    {
        void MarkAttendance();
    }
    abstract class Staff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public abstract double CalculateSalary();
        public virtual void MarkAttendance()
        {
            Console.WriteLine(Name + " attendence marked");
        }
    }
    class PermanentStaff : Staff, IAttendence
    {
        public double BasicSalary { get; set; }
        public override void MarkAttendance()
        {
            Console.WriteLine(Name + " attendence marked");
        }
        public override double CalculateSalary()
        {
            return BasicSalary + (0.2 * BasicSalary);
        }
    }
    class ContractStaff : Staff, IAttendence
    {
        public double BasicSalary { get; set; }
        public override void MarkAttendance()
        {
            Console.WriteLine(Name + " attendence marked");
        }
        public override double CalculateSalary()
        {
            return BasicSalary + (0.1 * BasicSalary);
        }
    }
    class Program15
    {
        static void Main()
        {
            List<Staff> list = new List<Staff>();

            PermanentStaff permanentStaff = new PermanentStaff();
            permanentStaff.ID = 001;
            permanentStaff.Name = "Tim";
            permanentStaff.Department = "Finance";
            permanentStaff.BasicSalary = 25000;

            ContractStaff contractStaff = new ContractStaff();
            contractStaff.ID = 002;
            contractStaff.Name = "Alen";
            contractStaff.Department = "HR";
            contractStaff.BasicSalary = 28000;

            list.Add(permanentStaff);
            list.Add(contractStaff);

            foreach (Staff s in list)
            {
                s.MarkAttendance();
                Console.WriteLine("Salary: " + s.CalculateSalary());
                Console.WriteLine();
            }
        }
    }
   
}
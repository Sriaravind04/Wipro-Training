using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working. ");
        }
    }
    class Manager : Employee {
        public override void Work()
        {
            Console.WriteLine("manager is supervising");
        }
    }
}
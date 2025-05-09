using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class program2
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.Work();//calls base method

            Manager mgr = new Manager();
            mgr.Work();//calls overridden method

            //Polymorphism
            Employee polyEmp = new Employee();
            polyEmp.Work();//calls overriden method
        }
    }
}
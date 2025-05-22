using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program8
    {
        static void Main() { 
            Dictionary<int, decimal> Employees = new Dictionary<int, decimal>{};
            Employees[101] = 100000.00m;
            Employees[102] = 110000.00m;
            Employees[103] = 120000.00m;
            Employees[104] = 130000.00m;
            Employees[105] = 150000.00m;

            Console.WriteLine("Enter an Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (Employees.ContainsKey(id))
            {
                Console.WriteLine(Employees[id]);
            }
            else {
                Console.WriteLine("not found");
            }



        }
    }
}
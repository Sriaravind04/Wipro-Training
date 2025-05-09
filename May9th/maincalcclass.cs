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
            Calculator calc = new Calculator();

            Console.WriteLine("Addition");
            Console.WriteLine("2 + 3 = " + calc.Add(2, 3));
            Console.WriteLine("2.5 + 3.7 = " + calc.Add(2.5, 3.7));
            Console.WriteLine("1 + 2 + 3 = " + calc.Add(1, 2, 3));
        }
    }
}
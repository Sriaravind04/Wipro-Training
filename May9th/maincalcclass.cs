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


            Console.WriteLine("subtraction");
            Console.WriteLine("3-2 = "+calc.sub(3, 2));
            Console.WriteLine("133 - 233 = " + calc.sub(133, 233));
            Console.WriteLine("12-1-4 = " + calc.sub(12, 1, 4));

            Console.WriteLine("multiplication");
            Console.WriteLine("4 * 5 = " + calc.mul(4, 5));
            Console.WriteLine("10 * 10 = " + calc.mul(10, 10));
            Console.WriteLine("192 * 1 * 12 = " + calc.mul(192, 1, 12));
        }
    }
}
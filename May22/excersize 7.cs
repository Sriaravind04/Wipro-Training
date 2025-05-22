using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program7
    {
        static void Main() {
            List<int> full = new List<int> { 1,2,3,4,5,6,7,8,9,0};

            var oddlist = full.Where(x=> x % 2 != 0);
            var evenlist = full.Where(x => x % 2 == 0);
            Console.WriteLine("odd list");
            foreach (var x in oddlist) {
                Console.WriteLine(x);
            }

            Console.WriteLine("even list");
            foreach (var x in evenlist) {
                Console.WriteLine(x);
            }
        }
    }
}
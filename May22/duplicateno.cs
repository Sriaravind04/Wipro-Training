using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program12
    {
        static void Main() { 
            List<int> nos = new List<int> { 1,1,2,3,3,4,5};

            var duplicate = nos
                            .GroupBy(n=> n).Where(g => g.Count() >1).Select(g => g.Key).ToList();
            Console.WriteLine("duplicate no ");

            foreach(var n in duplicate) Console.WriteLine(n);
        }
    }
}
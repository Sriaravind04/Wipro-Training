using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program6
    {
        static void Main() {
            string sentence = "C# is great and C# is fun";

            var words = sentence.Split(' ');
            var grouped = words
                          .GroupBy(x => x)
                          .Select(g => new { words = g.Key, Count = g.Count() });
            foreach (var group in grouped)
            {
                Console.WriteLine($"{group.words}: {group.Count}");
            }
        }
    }
}
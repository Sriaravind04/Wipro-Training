using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program11
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "firstname", "secondname", "thirdname", "fourthname", "fifthname", "sixthname", "seven", "eight", "nine" };

            var vowelstart = names.Where(name => "AEIOUaeiou".Contains(name[0])).ToList();

            Console.WriteLine("names starts with a vowel");

            foreach (var vowel in vowelstart)
            {
                Console.WriteLine(vowel);
            }
        }
    }
}
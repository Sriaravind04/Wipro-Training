using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    //creating a new thread
    class Program2
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Thread thread = new Thread(() =>
            {
                Console.WriteLine($"Sum: {a + b}");
            });
            thread.Start();
        }
    }
}

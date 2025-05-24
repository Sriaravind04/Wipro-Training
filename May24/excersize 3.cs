using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program3
    {
        static void ProcessItem(object item) { 
            Console.WriteLine($"Processing item {item}" )   ;
            Thread.Sleep(1000);
            Console.WriteLine($"Finished item {item}");
        }
        static void Main() {
            Console.WriteLine("Running 5 tasks using ThreadPool...\n");
            for (int i = 1; i <= 5; i++) {
                int item = i;
                ThreadPool.QueueUserWorkItem(ProcessItem, item);
            }
            Thread.Sleep(3000);
            Console.WriteLine("\nAll tasks done");
        }
    }

}
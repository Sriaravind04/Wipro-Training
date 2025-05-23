using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program4
    {
        static void DoWork(object state)
        {
            Console.WriteLine($"ThreadPool Task Started - {state}");
            Thread.Sleep(1000); //simulate work
            Console.WriteLine($"ThreadPool Task Finished - {state}");
        }
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                ThreadPool.QueueUserWorkItem(DoWork, $"Task {i}");
            }
            Console.WriteLine("Main thread continues...");
            Thread.Sleep(3000); //Wait for background tasks to completes
            Console.WriteLine("Main thread ends.");
        }
    }
}
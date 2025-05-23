using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    //threading creating and sleep for some time and start and join
    class Program3
    {
        static void DoWork(string name) {
            for (int i = 1; i <= 3; i++) { 
            Console.WriteLine($"Thread {name} - Step {i}");
            Thread.Sleep(500);
        }
        Console.WriteLine($"Thread {name} finished.");
            }
        static void Main()
        {
            //creating multiple threads
            Thread t1 = new Thread(() => DoWork("A"));
            Thread t2 = new Thread(() => DoWork("B"));
            Thread t3 = new Thread(() => DoWork("C"));

            t1.Start();
            t1.Join();

            t2.Start();
            t2.Join();

            t3.Start();
            t3.Join();

            Console.WriteLine("All threads completed. Main thread ends");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program2
    {
        static void Main() {
            Thread thread1 = new Thread(PrintNumber);
            Thread thread2 = new Thread(computesum);
            Thread thread3 = new Thread(wait);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("ALl task done");


        }

        public static void PrintNumber() {
            Console.WriteLine("print is started");
            Thread.Sleep(1000);
            for (int i = 0; i < 5; i++) {
                
               
                Console.WriteLine(i);
            }
            Console.WriteLine("print is completed");
        }
        public static void computesum() {
            Console.WriteLine("sum is started");
            int sum = 0;
            Thread.Sleep(1000);
            for (int i = 0; i <= 10; i++) {
             
                sum += i;
                
            }
            Console.WriteLine($"total sum is: {sum}");
            Console.WriteLine("sum is stopped");
        }
        public static void wait() {
            Console.WriteLine("wait is started . going to sleep for 5 second");
            Thread.Sleep(8000);
            Console.WriteLine("all tasks completed");

        }
    }
}
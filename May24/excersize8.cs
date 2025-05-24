using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program8
    {
        static async Task RiskyTaskAsync(string name)
        {
            Console.WriteLine($"{name} started...");
            await Task.Delay(1000);
            if (name == "Task 2")
            {
                throw new Exception($"{name} failed due to an  error.");
            }
            Console.WriteLine($"{name} completed successfully.");
        }
        static async Task RunWithExceptionHandlingAsync()
        {
            Task t1 = RiskyTaskAsync("Task1");
            Task t2 = RiskyTaskAsync("Task2");//this one will fail
            Task t3 = RiskyTaskAsync("Task3");

            try
            {
                await Task.WhenAll(t1, t2, t3);
            }
            catch (Exception ex) {
                Console.WriteLine($"\n Exception caught: {ex.Message}") ;
            }

            //optional: check task status
            Console.WriteLine($"\nTask 1 status: {t1.Status}");
            Console.WriteLine($"Task 2 status: {t2.Status}");
            Console.WriteLine($"Task 3 status: {t3.Status}");
        }
        static async Task Main()
        {
            await RunWithExceptionHandlingAsync();
        }

    }
}
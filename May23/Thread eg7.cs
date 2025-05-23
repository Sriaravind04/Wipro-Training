using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program6
    {
        static async Task Main(string[] args) {
            Console.WriteLine("Starting all tasks....");

            //start tasks simultaneously (they begin running now)
            Task task1 = DoWorkAsync("Task 1", 2000);
            Task task2 = DoWorkAsync("Task 2", 3000);
            Task task3 = DoWorkAsync("Task 3", 1000);

            //Await all tasks to complete
            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("All tasks completed.");
        }

        static async Task DoWorkAsync(string name, int delay)
        {
            Console.WriteLine($"{name} started");
            await Task.Delay(delay); //simultes async work
            Console.WriteLine($"{name} completed after {delay}ms.");
        }
    }
}
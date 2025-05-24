using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program7
    {
        static async Task SimulateWorkAsync(string name, int delay)
        {
            Console.WriteLine($"{name} started...");
            await Task.Delay(delay);
            Console.WriteLine($"{name} finished.");
        }
        static async Task RunSequentialAsync()
        {
            Stopwatch sw = Stopwatch.StartNew();
            await SimulateWorkAsync("task 1", 2000);
            await SimulateWorkAsync("task 2", 2000);
            await SimulateWorkAsync("task 3", 2000);

            sw.Stop();
            Console.WriteLine($"Sequential total time: {sw.ElapsedMilliseconds}");
        }
        static async Task RunParallelAsync()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Task t1 = SimulateWorkAsync("Task 1", 2000);
            Task t2 = SimulateWorkAsync("Task 2", 2000);
            Task t3 = SimulateWorkAsync("Task 3", 2000); 

            await Task.WhenAll(t1, t2, t3);
            sw.Stop();
            Console.WriteLine($"Parallel total time: {sw.ElapsedMilliseconds} ms\n");
        }
        static async Task Main()
        {
            Console.WriteLine("Running sequential execution:\n");
            await RunSequentialAsync();

            Console.WriteLine("Running parallel execution:\n");
            await RunParallelAsync();
        }
    }
}
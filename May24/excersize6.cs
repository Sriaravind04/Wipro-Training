using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program6
    {
        static async Task<string> DoWorkAsync(string name, int delay)
        {
            await Task.Delay(delay);
            return name;
        }
        static async Task RunTaskRaceAsync()
        {
            Task<string> task1 = DoWorkAsync("Task A", 3000);
            Task<string> task2 = DoWorkAsync("Task B", 2000);
            Task<string> task3 = DoWorkAsync("Task C", 1000);

            Task<string> firstFinished = await Task.WhenAny(task1, task2, task3);
            Console.WriteLine($"First task to finish: {firstFinished.Result}");
        }
        static async Task Main()
        {
            await RunTaskRaceAsync();
        }
    }
}

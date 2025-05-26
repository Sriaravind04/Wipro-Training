using System;
using System.Threading.Tasks;

class Program8
{
    static async Task Main()
    {
        List<Task> tasks = new List<Task>();
        tasks.Add(Task.Run(() => DoWork("Task1")));
        tasks.Add(Task.Run(() => DoWork("Task2", throwError: true)));
        tasks.Add(Task.Run(() => DoWork("Task3")));
        tasks.Add(Task.Run(() => DoWork("Task4", throwError: true)));
        tasks.Add(Task.Run(() => DoWork("Task5")));

        try
        {
            await Task.WhenAll(tasks);
        }
        catch (AggregateException ex) {
            Console.WriteLine("\nExceptions occured during task execution: ");
            foreach (var inner in ex.InnerExceptions) {
                Console.WriteLine($"- {inner.Message}");
            }
        }
        Console.WriteLine("\nAll tasks attempted. Processing complete.");
    }
    static void DoWork(string taskName, bool throwError = false)
    {
        Console.WriteLine($"{taskName} started.");

        Task.Delay(300).Wait();

        if (throwError)
            throw new InvalidOperationException($"{taskName} encountered an erro.");

        Console.WriteLine($"{taskName} completed successfully.");
    }
}
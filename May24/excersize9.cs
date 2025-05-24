using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program9
    {
        static async Task DoWorkAsync(CancellationToken token)
        {
            Console.WriteLine("task started...");
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    token.ThrowIfCancellationRequested();
                    Console.WriteLine($"Working....step {i}");
                    await Task.Delay(1000, token);
                }
                Console.WriteLine("Task completed successfully");
            }
            catch (OperationCanceledException) {
                Console.WriteLine(" Task was cancelled.");
            }
        }
        static async Task Main()
        {
            using CancellationTokenSource cts = new CancellationTokenSource();
            Task workTask = DoWorkAsync(cts.Token);

            //cancel after 2 seconds
            await Task.Delay(2000);
            cts.Cancel();

            await workTask;
        }
    }
}
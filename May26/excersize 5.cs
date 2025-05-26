using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program4
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Task<string> server1Task = GetServerResponse("Server1", 1000, token);
            Task<string> server2Task = GetServerResponse("Server2", 2000, token);
            Task<string> server3Task = GetServerResponse("Server3", 1500, token);

            Task<string> fastestResponseTask = await Task.WhenAny(server1Task, server2Task, server3Task);

            cts.Cancel();

            string fastestResponse = await fastestResponseTask;

            Console.WriteLine($"Fastest response: {fastestResponse}");

            // Wait for all tasks to complete to ensure all are processed (including cancellations)
            await Task.WhenAll(server1Task, server2Task, server3Task);
        }

        static async Task<string> GetServerResponse(string serverName, int maxDelay, CancellationToken token)
        {
            Random rand = new Random();
            int delay = rand.Next(500, maxDelay); // Random delay between 500ms and maxDelay
            try
            {
                Console.WriteLine($"Requesting {serverName}... (will take {delay} ms)");
                await Task.Delay(delay, token);
                return $"{serverName} response (after {delay} ms)";
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine($"{serverName} request was cancelled.");
                return $"{serverName} request cancelled";
            }
        }
    }
   
}
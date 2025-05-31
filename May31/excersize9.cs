using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp16
{
    class Program9
    {
      
        static async Task Main()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Task<string> city1 = GetWeatherAsync("Chennai", 2000);
            Task<string> city2 = GetWeatherAsync("Banglore", 3000);
            Task<string> city3 = GetWeatherAsync("Mumbai", 2500);

            string[] results =  await Task.WhenAll(city1, city2, city3);

            stopwatch.Stop();
            Console.WriteLine("\nWeather Reports:");
            foreach (var result in results) { 
                Console.WriteLine(result);
            }
            Console.WriteLine($"\nTotal time taken: {stopwatch.ElapsedMilliseconds} ms");
        }
        static async Task<string> GetWeatherAsync(string city,int delay)
        {
            Console.WriteLine($"Fetching weather for {city}...");
            await Task.Delay(delay);
            return $"Weather for {city}: Sunny, {25 + new Random().Next(5)}^C";
        }
    }
}

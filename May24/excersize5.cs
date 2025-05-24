using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program5
    {
        static async Task<int> GetTemperatureAsync(string city)
        {
            await Task.Delay(1000); //simulate API delay
            Random rand = new Random();
            int temp = rand.Next(15, 40); //Random temperature between 15 and 40
            return temp;

        }
        static async Task RunTemperatureCheckAsync()
        {
            string[] cities = { "chennai ", "delhi", "mumbai" };
            foreach (var city in cities) { 
                int temp = await GetTemperatureAsync(city);
                Console.WriteLine($"Temperature in {city}: {temp} C");
            }
        }
        static async Task Main()
        { 
            await RunTemperatureCheckAsync();
        }
    }
}
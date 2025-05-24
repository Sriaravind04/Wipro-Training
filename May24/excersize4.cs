using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program4
    {
        static async Task DownloadFileAsync(string fileName, int delay)
        {
            Console.WriteLine($"Starting download: {fileName}");
            await Task.Delay( delay ); //simulate network delay
            Console.WriteLine($"Finished download: {fileName}");
        }
        static async Task RunDownloadsAsync()
        {
            Stopwatch sw = Stopwatch.StartNew();

            //Start downloads in parallel
            Task t1 = DownloadFileAsync("file1.txt", 2000);
            Task t2 = DownloadFileAsync("file2.txt", 3000);
            Task t3 = DownloadFileAsync("file3.txt", 1500);

            await Task.WhenAll(t1, t2, t3);

            sw.Stop();
            Console.WriteLine($"\nAll downloads completed in {sw.ElapsedMilliseconds}");

        }
        static async Task Main()
        {
            await RunDownloadsAsync();
        }
    }
}
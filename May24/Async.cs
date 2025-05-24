using System;
using System.Threading.Tasks;

class Program
{
    //Async method to simulate a file download

    static async Task DownloadFileAsync(string filename, int delayMs)
    {
        Console.WriteLine($"Starting download: {filename}");
        await Task.Delay(delayMs); //Simulate time taken to download
        Console.WriteLine($"Completed download: {filename} ({delayMs}ms");
    }
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting all downloads...\n");

        //start all downlaods concurrently
        Task file1 = DownloadFileAsync("file1.pdf", 3000);
        Task file2 = DownloadFileAsync("file2.jpg", 2000);
        Task file3 = DownloadFileAsync("file3.zip", 4000);

        //Wait for all downloads to complete
        await Task.WhenAll(file1, file2, file3);

        Console.WriteLine("\nAll downloads completed.");
    }
}
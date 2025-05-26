using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program7
    {
        static async Task Main()
        {
            List<string> imageFiles = new List<string>();
            for (int i = 1; i <= 20; i++)
            {
                imageFiles.Add($"Image_{i}.jpg");
            }
            int total = imageFiles.Count;
            int processedCount = 0;

            object lockObj = new object();

            await Parallel.ForEachAsync(imageFiles, async (image, cancellationToken) =>
            {
                await Task.Delay(200, cancellationToken);

                int currentCount;
                lock (lockObj)
                {
                    processedCount++;
                    currentCount = processedCount;
                }
                int percentage = (currentCount * 100) / total;
                Console.WriteLine($"Processed: {image} [{percentage}% complete]");
            });
            Console.WriteLine("all images processed.");
        }
    }
}
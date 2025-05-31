using System;
using System.IO;
using System.Threading;

namespace ConsoleApp16
{
    class FileReader
    {
        private static int totalLines = 0;
        private static readonly object lockObj = new object();

        public void ReadFile(string filePath)
        {
            try
            {
                int lineCount = 0;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }

                lock (lockObj)
                {
                    totalLines += lineCount;
                }

                Console.WriteLine($"{Path.GetFileName(filePath)}: {lineCount} lines read.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading {filePath}: {ex.Message}");
            }
        }

        public static int GetTotalLines()
        {
            return totalLines;
        }
    }

    class Program4
    {
        public static void Main()
        {
            FileReader fileReader = new FileReader();

            // Replace these with actual file paths on your system
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            string file3 = "file3.txt";

            // Create threads
            Thread t1 = new Thread(() => fileReader.ReadFile(file1));
            Thread t2 = new Thread(() => fileReader.ReadFile(file2));
            Thread t3 = new Thread(() => fileReader.ReadFile(file3));

            // Start threads
            t1.Start();
            t2.Start();
            t3.Start();

            // Wait for threads to finish
            t1.Join();
            t2.Join();
            t3.Join();

            // Print total line count
            Console.WriteLine($"\n✅ Total lines across all files: {FileReader.GetTotalLines()}");
        }
    }
}

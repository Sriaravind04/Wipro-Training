using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    abstract class CompressionStrategy
    {
        public abstract void Compress(string inputPath, string outputPath);
    }
    class ZipCompression : CompressionStrategy
    {
        public override void Compress(string inputPath, string outputPath)
        {
            Console.WriteLine($"Compressing '{inputPath}' to '{outputPath}.zip' using ZIP compression.");
        }
    }
    class RarCompression : CompressionStrategy
    {
        public override void Compress(string inputPath, string outputPath)
        {
            Console.WriteLine($"Compressing '{inputPath}' to ' {outputPath}.rar' using RAR compression");
        }
    }
    class Compressor
    {
        private CompressionStrategy _strategy;

            public Compressor(CompressionStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(CompressionStrategy strategy)
        {
            _strategy = strategy;
        }
        public void Compress(string inputPath, string OutputPath) { 
            _strategy.Compress(inputPath, OutputPath);
        }
    }
    class Program6
    {
        static void Main()
        {
            Compressor compressor = new Compressor(new ZipCompression());
            compressor.Compress("MyDocuments", "Backup_Zip");

            compressor.SetStrategy(new RarCompression());
            compressor.Compress("MyDocuments", "Backup_Rar");
        }
    }
}
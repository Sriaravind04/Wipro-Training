using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Document {
        public abstract void PrintContent();
        public void ShowDocumentType(string Type) {
            Console.WriteLine($"Document Type: {Type}");
        }
    }
    class WordDocument :Document{
        public override void PrintContent() {
            Console.WriteLine("Printing Word Document");
        }
    }
    class PDFDocument : Document{
        public override void PrintContent() {
            Console.WriteLine("Printing PDF Document");
        }
    }
    class Program2
    {
        static void Main() { 
            WordDocument word = new WordDocument();
            word.ShowDocumentType("word");
            word.PrintContent();

            PDFDocument pdf = new PDFDocument();
            pdf.ShowDocumentType("PDF");
            pdf.PrintContent();

        }
    }
}
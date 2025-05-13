using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Action
    {
        Action<int> printActionDel = ConsolePrint;
        Action<int> printToPrinter = PrinterPrint;

        printActionDel(10);
        printToPrinter(45);
        Console.Read();


    }
    public static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        public static void PrinterPrint(int i) {
            Console.WriteLine("this is being printer to the printer");
        }
    }
}
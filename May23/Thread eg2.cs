using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Progaram1
    {
        static void PrintMesssage(object message)
        {
            string msg = (string)message; //cast to correct type
            Console.WriteLine("Message: " + msg);
        }

        static void Main()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(PrintMesssage));
            thread.Start("Hello from the thread!");
        }
    }
}
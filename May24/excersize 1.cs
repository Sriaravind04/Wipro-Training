using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program1
    {
        static bool pause = false;
        static bool stop = false;
        static Thread numberThread;
        static void  Printnumbers() {
            for (int i=1; i<= 100; i++) {
                if (stop)
                    break;
                while (pause)
                {
                    Thread.Sleep(100);
                }

                Console.WriteLine(i);
                Thread.Sleep(100);

            }
            Console.WriteLine("thread completed");
        }

        static void Main() { 
            numberThread = new Thread(Printnumbers);
            numberThread.Start();

            Console.WriteLine($"thread state after start(). {numberThread.ThreadState}");

            Thread.Sleep(2000);

            pause = true;
            Console.WriteLine("Thread paused");
            Console.WriteLine($"Thread state after paused: {numberThread.ThreadState}");

            Thread.Sleep(3000);
            pause = false; //resume the thread
            Console.WriteLine("Thread resumed");

            Console.WriteLine($"Thread state after resume: {numberThread.ThreadState}");

            Thread.Sleep(2000);
            stop = true;
            Console.WriteLine("Thread Stopping...");

            numberThread.Join(); //wait for the thread to finish
            Console.WriteLine($"Thread State after Join(): {numberThread.ThreadState}");
            Console.WriteLine("Main thread exiting.");



        }
    }
}
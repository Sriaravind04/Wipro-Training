using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program3
    {
        static Queue<string> taskQueue = new Queue<string>();
        static object queueLock = new object();
        static bool isAddingCompleted = false;

        static void Main()
        {
            //start the worker thread
            Thread workerThread = new Thread(ProcessTasks);
            workerThread.Start();

            //Enqueue 5 tasks from Main
            for (int i = 1; i <= 5; i++)
            {
                lock (queueLock) { 
                    taskQueue.Enqueue($"Task {i}");
                    Monitor.Pulse(queueLock); //signal the worker that new task is available
                }
                Thread.Sleep(200); //simulate staggered task addition
            }

            //Indicate no more tasks will be added
            lock (queueLock) { 
                isAddingCompleted = true;
                Monitor.Pulse(queueLock); //Wake up the worker in case it's waiting
            }

            //wait for the worker to finish
            workerThread.Join();
            Console.WriteLine("ALl tasks processed. Main thread exiting.");
        }
        static void ProcessTasks()
        {
            while (true) {
                string task = null;
                lock (queueLock) {
                    //wait until there is a task or all work is done
                    while (taskQueue.Count == 0 && !isAddingCompleted) { 
                        Monitor.Wait(queueLock);
                    }
                    if (taskQueue.Count > 0)
                    {
                        task = taskQueue.Dequeue();
                    }
                    else if (isAddingCompleted) {
                        break;
                    }
                }

                if (task != null) {
                    Console.WriteLine($"Processing {task} on thread {Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(500);
                }
            }
            Console.WriteLine("Worker thread exiting");
        }
    }
}
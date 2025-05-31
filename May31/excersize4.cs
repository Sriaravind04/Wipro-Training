using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class File
    {
        public void File1()
        {
            Console.WriteLine("Reading file 1");
            Thread.Sleep(2500);

            Console.WriteLine("File 1 completed");
        }
        public void File2()
        {
            Console.WriteLine("Reading file 2");
            Thread.Sleep(2000);
            Console.WriteLine("File 2 completed");
        }
        public void File3()
        {
            Console.WriteLine("Reading file 3");
            Thread.Sleep(1000);
            Console.WriteLine("File 3 completed");
        }
    }
    class Program4
    {
        public static void Main()
        {
            File obj = new File();
            Thread thread = new Thread(obj.File1);
            thread.Start();

            Thread thread1 = new Thread(obj.File2);
            thread1.Start();

            Thread thread2 = new Thread(obj.File3);
            thread2.Start();

            thread.Join();
            thread1.Join();
            thread2.Join();
        }
    }
}

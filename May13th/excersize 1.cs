using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface ITransport
    {
        void Start();
        void Stop();
    }
    public class Bus : ITransport
    {
        public void Start() {
            Console.WriteLine("Bus is strating");
        }
        public void Stop() {
            Console.WriteLine("Train is starting ");
        }
        
    }
    public class Train : ITransport {
        public void Start() {
            Console.WriteLine("bus is starting");
        }
        public void Stop() {
            Console.WriteLine("Bus is stopping");
        }
    }
    class Program12
    {
        static void Main(string[] args) {
            ITransport transport;
            
            transport = new Bus();
            transport.Start();
            transport.Stop();

            transport = new Train();
            transport.Start();
            transport.Stop();

            Console.ReadLine();
        }
    }
}

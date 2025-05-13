using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SimpleDelegate
    {
        public delegate int SomeOperation(int i, int j);

        class Program
        {
            static int Sum(int x, int y) {
                return x + y;
            }
            static void Main(string[] args) {
                SomeOperation add = Sum;
                int result = add(10, 10);
                Console.WriteLine(result);
            }
        }
    }
}
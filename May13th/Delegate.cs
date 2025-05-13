using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Simple_Deligate
    {
        //Define a custom delegate that has a string parameter and return void
        delegate void CustomDel(string s);

        class TestClass
        {
            //Define two methods that have  the same signature as CustomeDel.
            static void Hello(string s)
            { 
                Console.WriteLine($" Hello, {s}!");
            }
            static void Main()
            {
                //Declare instance of the custom delegate
                CustomDel hiDel;

                hiDel = Hello;
                Console.WriteLine("Invoking delegate hiDel:");
                hiDel("A");
            }
        }
    }
}

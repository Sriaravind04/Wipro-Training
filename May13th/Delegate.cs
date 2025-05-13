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
            static void Goodbye(string s) {
                Console.WriteLine($" Goodbye, {s}!");
            }
            static void Main()
            {
                //Declare instance of the custom delegate
                CustomDel hiDel,byeDel,multiDel;
               
                hiDel = Hello;
                //Create the delegate object byedel that reference the
                //method goodbye.
                byeDel = Goodbye;

                //the two delegates , hidel and byedel , are combined 
                //toform multidel.
                //MULTICAST DELEGATE - SIMPLE INVOCATION
                multiDel = hiDel + byeDel;

                Console.WriteLine("Invoking delegate hiDel: ");
                hiDel("A");
                Console.WriteLine("Invoking delegate byeDel:");
                byeDel("B");
                Console.WriteLine("Invoking delegate multiDel:");
                    multiDel("C");
               
            }
        }
    }
}

using System.Collections;
using System.Globalization;
class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList() { 4,1,8,3};
        list.Sort();
        foreach (var num in list)
        { 
            Console.WriteLine(num);
        }
        list.Reverse();
        Console.WriteLine("Reversed: ");

        foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
}
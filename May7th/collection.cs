using System;
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("apple");
        list.Add(42);
        list.Add(3.14);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}

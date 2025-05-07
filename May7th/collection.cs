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

//insert
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("apple");
        list.Add(42);
        list.Add(3.14);

        list.Insert(1, "INSERTED");
        Console.WriteLine("element at index 1: " + list[1]);



        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}
//remove
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("apple");
        list.Add(42);
        list.Add(3.14);

        list.Remove(42);//removethe no 

        list.RemoveAt(0);//remove the index
        Console.WriteLine("Count affter removal: " + list);



        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}
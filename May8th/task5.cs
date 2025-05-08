using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

class Program
{ 
    static void Main()
    {
       Dictionary<string,string> phonebook = new Dictionary<string,string>();
        phonebook.Add("aravind", "1234556787");
        phonebook.Add("arun",    "2222222222");
        phonebook.Add("charlie", "3333333333");
        phonebook.Add("rahul",   "4444444444");
        phonebook.Add("sharma", "5555555555");

        phonebook["rahul"] = "0000000000";

        if (phonebook.ContainsKey("aravind"))
        {
            Console.WriteLine("found");

        }
        else {
            Console.WriteLine("not found");
        }

        foreach (var contacts in phonebook) { 
            Console.WriteLine(contacts);
        }
    }
}
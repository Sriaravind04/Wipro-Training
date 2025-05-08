using System;
using System.Collections.Generic;

class Program
{ 
    static void Main()
    {
       //Creating a queue of strings
       Queue<string> customers = new Queue<string>();

        //Enqueue elements
        customers.Enqueue("Amit");
        customers.Enqueue("Neha");
        customers.Enqueue("Ravi");

        Console.WriteLine("Serving Customers: ");
        while (customers.Count > 0) { 
            Console.WriteLine("Serving: " +customers.Dequeue());
        }
        //tdoken system example
        
    }
}

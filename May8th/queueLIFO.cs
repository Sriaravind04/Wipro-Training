using System;
using System.Collections.Generic;

class Program
{ 
    static void Main()
    {
       //creating a stack of strings
       Stack<string> books = new Stack<string>();

        //Pushing elements onto the stack 
        books.Push("C# Programming");
        books.Push("Data Structure");
        books.Push("Machine Learning ");

        Console.WriteLine("books in the stack:");
        foreach (var book in books) {
            Console.WriteLine(book);
        }
        //Pooping an element
        Console.WriteLine("\nPooped: " + books.Pop());

        //Peeking at the top element
        Console.WriteLine("next on the stack: " + books.Peek());
        
    }
}
//example is phone,whatsapp,gmail wherer we get the lastest one front

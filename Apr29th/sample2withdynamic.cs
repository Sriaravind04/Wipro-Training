using System;

public class HelloWorld
{
     public static void Main(string[] args)
     {
         int age = 25;
         string name = "John";
         bool isStudent = true;
         double fees = 55000.75;
        
        
         Console.WriteLine ("Fees: " +fees);
         Console.WriteLine($"Name: {name}");
         Console.WriteLine($"Age: {age}");
         Console.WriteLine($"Is Student: {isStudent}");
         Console.WriteLine($"Fees: {fees}");
       
     }
}
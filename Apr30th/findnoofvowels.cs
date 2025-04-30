using System;


public class HelloWorld
{
   static int CountVowels(string sentence) {
       int count =0;
       string vowels = "aeiouAEIOU";
       
       foreach (char c in sentence) 
       {
           if(vowels.Contains(c))
           count++;
       }
       return count;
   } 
    static void Main()
    {
        string sentence = "Programming is fun";
        Console.WriteLine("no of vowels is: "+CountVowels(sentence));
    }
}
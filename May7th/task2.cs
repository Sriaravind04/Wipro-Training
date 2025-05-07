using System;
class Program
{
    static void Main() {
        Console.WriteLine("Enter the string input : ");
        string input = Console.ReadLine();
        string[] splits = input.Split(' ');
        answer(splits);
    }
    static void answer(string[] splits)
    {
        int maxLength = 0;
        string longestWord = "";
        foreach (string word in splits)
        {
            int wordLength = word.Length;
            if (wordLength > maxLength)
            {
                maxLength = wordLength;
                longestWord = word;
            }
        }
        Console.WriteLine(longestWord);
    }
}
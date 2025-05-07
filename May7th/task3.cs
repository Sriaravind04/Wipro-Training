using System;
class Program
{
    static void PrintDuplicate(string sentence)
    {
        string[] words = sentence.ToLower().Split(' ');
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        List<string> duplicates = new List<string>();

        foreach (string word in words) {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;  


            }
            else
            {
                wordCount[word] = 1; 
                }
            }
        foreach (var item in wordCount)
        {
            if (item.Value > 1)
            { 
                duplicates.Add(item.Key);   
            }
        }
        Console.WriteLine("duplicate words: "+ string.Join(", ", duplicates));  
        }
    static void Main()
    {
        string input = "this is a test and this test is fun";
        PrintDuplicate(input);
    }
}
using System.Net.Http.Headers;

class Program
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        int wordCount = CountWords(input);
        Console.WriteLine(wordCount);
    }
    static int CountWords(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
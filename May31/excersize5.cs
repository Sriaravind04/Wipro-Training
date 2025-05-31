using System;
class Program4
{
    public static void Main()
    {
        Console.WriteLine("Enter a paragraph: ");
        string paragraph = Console.ReadLine();

        string[] words = paragraph.Split(" ");

        Dictionary<string, int> frequency = new Dictionary<string, int>();
        int vowelCount = 0, consonantCount = 0;
        string longestWord = "", smallestWord = paragraph;

        foreach (string word in words)
        {
            if (frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;

            foreach (char c in word.ToLower())
            {
                if ("aeiou".Contains(c))
                    vowelCount++;
                else if (Char.IsLetter(c))
                    consonantCount++;
            }

            if (word.Length > longestWord.Length)
                longestWord = word;

            if (word.Length < smallestWord.Length)
                smallestWord = word;
        }
        Console.WriteLine("The frequency of words in paragraph: ");
        foreach (var word in frequency)
        {
            Console.WriteLine(word.Key + " : " + word.Value);
        }
        Console.WriteLine($"\nVowel Count: {vowelCount}");
        Console.WriteLine($"Consonant Count: {consonantCount}");

        Console.WriteLine($"\nLongest Word: {longestWord}");
        Console.WriteLine($"Smallest Word: {smallestWord}");
    }
}
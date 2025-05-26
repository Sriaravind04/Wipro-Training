using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program9
    {
        static void Main()
        {
            string text = "This is a test. This test is simple. Simple test works well.";


            string[] words = text.ToLower().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> freq = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (freq.ContainsKey(word))
                    freq[word]++;
                else
                    freq[word] = 1;
            }


            var top5 = freq.OrderByDescending(w => w.Value).Take(5);


            Console.WriteLine("Top 5 frequent words:");
            foreach (var w in top5)
            {
                Console.WriteLine($"{w.Key}: {w.Value}");
            }
        }
    }
   
}
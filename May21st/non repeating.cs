using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program2
    {
        static void Main(string[] args)
        {
            //Input String
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            //Step1: Count frequencies using a dictionary
            Dictionary<char,int> charCount = new Dictionary<char,int>();

            foreach (char c in input) {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            //Step 2: Find the first character with frequency 1
            char? firstNonRepeating = null;
            foreach (char c in input) {
                if (charCount[c] == 1) { 
                    firstNonRepeating = c;
                    break;
                }
            }

            if (firstNonRepeating != null)
            {
                Console.WriteLine("First non-repeadting character: " + firstNonRepeating);
            }
            else {
                Console.WriteLine("No non-repeating character found.");
            }
            }
        }
    }
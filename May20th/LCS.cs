using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Progrm3
    {
        static void Main()
        {
            string str1 = "ABCDGH";
            string str2 = "AEDFHR";

            var result = LCS(str1, str2);
            Console.WriteLine($"LCS: {result.Item2}, Length: {result.Item1}");
        }

        static (int, string) LCS(string str1, string str2)
        {
            int m = str1.Length;
            int n = str2.Length;
            int[,] dp = new int[m + 1, n + 1];

            // Fill the dp table
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }

            // Retrieve the LCS string
            int length = dp[m, n];
            char[] lcsChars = new char[length];
            int index = length - 1, iIndex = m, jIndex = n;

            while (iIndex > 0 && jIndex > 0)
            {
                if (str1[iIndex - 1] == str2[jIndex - 1])
                {
                    lcsChars[index--] = str1[iIndex - 1];
                    iIndex--;
                    jIndex--;
                }
                else if (dp[iIndex - 1, jIndex] > dp[iIndex, jIndex - 1])
                    iIndex--;
                else
                    jIndex--;
            }

            return (length, new string(lcsChars));
        }
    }
}
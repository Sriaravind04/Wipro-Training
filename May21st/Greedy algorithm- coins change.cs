using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program_1
    {
        static void Main(string[] args)
        {
            //Available denominations in descending order
            int[] denominations = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            //input amount
            Console.WriteLine("Enter the amount: ");
            int amount = int.Parse(Console.ReadLine());

            List<int> coinsUsed = new List<int>();
            int totalCoins = 0;

            foreach (int coin in denominations) {
                while (amount >= coin) {
                    amount -= coin;
                    coinsUsed.Add(coin);
                    totalCoins++;
                }
            }
            Console.WriteLine("Coins Used : " + string.Join(", ", coinsUsed));
            Console.WriteLine("total coins: " + totalCoins);
        }
    }
}
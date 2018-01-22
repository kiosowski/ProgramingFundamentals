using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var elements = Console.ReadLine();

            var jewelsPrice = prices[0];
            var goldPrice = prices[1];

            var totalExpenses = 0;
            var totalEarnings = 0;
            

            while (!elements.Equals("Jail Time"))
            {
                var elementsArr = elements.Split();

              
                var loot = elementsArr[0];
                var expenses = int.Parse(elementsArr[1]);
                totalExpenses += expenses;
                foreach (var character in loot.ToCharArray())
                {
                    if (character.Equals('%'))
                    {
                        totalEarnings += jewelsPrice;
                    }
                    else if (character.Equals('$'))
                    {
                        totalEarnings += goldPrice;
                    }
                }
                elements = Console.ReadLine();
            }
            if (totalEarnings>=totalExpenses)
            {
                var moneyEarned = totalEarnings - totalExpenses;
                Console.WriteLine($"Heists will continue. Total earnings: {moneyEarned}.");

            }
            else
            {
                var moneyLost = totalExpenses - totalEarnings;
                Console.WriteLine($"Have to find another job. Lost: {moneyLost}.");
            }
            
        }
    }
}

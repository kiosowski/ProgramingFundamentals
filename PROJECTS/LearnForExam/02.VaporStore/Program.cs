using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentBalance = decimal.Parse(Console.ReadLine());
            var totalMoney = currentBalance;
            var game = Console.ReadLine();
            while (game != "Game Time")
            {
                decimal gamePrice = 0;
                var isFound = true;
                switch (game)
                {
                    case "OutFall 4":
                        gamePrice = 39.99m;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99m;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99m;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99m;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99m;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99m;
                        break;
                    default:
                        isFound = false;
                        break;
                }
                if (isFound)
                {
                    if (currentBalance > gamePrice)
                    {
                        currentBalance -= gamePrice;
                        Console.WriteLine($"Bought {game}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                game = Console.ReadLine();

            }
            if (currentBalance >= 0)
            {
                totalMoney -= currentBalance;
                Console.WriteLine($"Total spent: ${totalMoney:f2}. Remaining: ${currentBalance:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }

    }
}

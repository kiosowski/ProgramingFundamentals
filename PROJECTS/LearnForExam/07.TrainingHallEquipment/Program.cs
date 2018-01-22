using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var numberOfItems = decimal.Parse(Console.ReadLine());


            var spentMoney = 0m;
            for (int i = 0; i < numberOfItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = decimal.Parse(Console.ReadLine());
                var itemCount = decimal.Parse(Console.ReadLine());
                var itemTotalPrice = itemCount * itemPrice;
                spentMoney += itemTotalPrice;

                if (itemCount == 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
            }

            Console.WriteLine($"Subtotal: ${spentMoney:f2}");

            if (spentMoney <= budget)
            {
                var moneyLeft = budget - spentMoney;
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                var notEnough = Math.Abs(budget - spentMoney);
                Console.WriteLine($"Not enough. We need ${notEnough:f2} more.");
            }
        }
    }
}

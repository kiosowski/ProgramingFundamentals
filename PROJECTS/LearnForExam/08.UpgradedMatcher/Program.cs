using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var productNames = Console.ReadLine().Split().ToArray();
            var productQuantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var productPrices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            var currentOrder = Console.ReadLine();

            while (!currentOrder.Equals("done"))
            {
                var currentProductName = currentOrder.Split().First();
                var currentQuantityOrdered = long.Parse(currentOrder.Split().Last());

                var index = Array.IndexOf(productNames, currentProductName);

                if (productQuantities.Length > index && productQuantities[index] >= currentQuantityOrdered)
                {
                    var currentTotalPrice = currentQuantityOrdered * productPrices[index];

                    productQuantities[index] -= currentQuantityOrdered;
                    Console.WriteLine($"{currentProductName} x {currentQuantityOrdered} costs {currentTotalPrice:F2}");

                }
                else
                {
                    Console.WriteLine($"We do not have enough {currentProductName}");
                }
                currentOrder = Console.ReadLine();
            }
           
        }
    }
}

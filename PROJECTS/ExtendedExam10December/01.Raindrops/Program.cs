using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _01.Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var density = decimal.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                var regionsInformation = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

                var raindropsCount = regionsInformation[0];
                var squareMeters = regionsInformation[1];

               
                
                    var regionalCoefficient = raindropsCount / squareMeters;

                    sum += regionalCoefficient;
                

            }
            if (density == 0)
            {
                Console.WriteLine($"{sum:f3}");
            }
            if(density > 0)
            {
                var dividedSum = sum / density;
                Console.WriteLine($"{dividedSum:f3}");
            }
        }
    }
}


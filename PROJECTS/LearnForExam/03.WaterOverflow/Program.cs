using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var currentCapacity = 0;
            var maxCapacity = 255;

            for (int i = 0; i < count; i++)
            {
                var liters = int.Parse(Console.ReadLine());

                if (currentCapacity + liters > maxCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                currentCapacity += liters;

            }
            Console.WriteLine(currentCapacity);
        }
    }
}

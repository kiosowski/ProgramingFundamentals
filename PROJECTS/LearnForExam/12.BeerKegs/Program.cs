using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());

            var biggestKeg = string.Empty;

            var maxKegVolume = double.MinValue;

            for (int i = 0; i < linesCount; i++)
            {
                var kegModel = Console.ReadLine();
                var kegRadius = double.Parse(Console.ReadLine());
                var kegHeight = double.Parse(Console.ReadLine());

                var currentKegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (currentKegVolume > maxKegVolume)
                {
                    biggestKeg = kegModel;
                    maxKegVolume = currentKegVolume;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}

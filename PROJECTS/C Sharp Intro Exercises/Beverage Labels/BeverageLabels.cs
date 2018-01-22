﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            var kcal = (volume * energy) / 100;
            var sugars = (volume * sugar) / 100;
            Console.WriteLine("{0}ml {1}:",volume,name);
            Console.WriteLine("{0}kcal, {1}g sugars", kcal,sugars);

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumbers = int.Parse(Console.ReadLine());
            int combinations = 0;
            int firstNumber = 0;
            int secondNumer = 0;
            var lastCombination = string.Empty;

            for (firstNumber = n; firstNumber <= m; firstNumber++)
            {
                for (secondNumer = n; secondNumer <= m; secondNumer++)
                {
                    combinations++;

                    if (firstNumber + secondNumer == magicalNumbers && firstNumber > secondNumer)
                    {
                        lastCombination = $"Number found! {firstNumber} + {secondNumer} = {magicalNumbers}";

                    }
                  
                }
            }

            if (lastCombination == string.Empty)
                Console.WriteLine($"{combinations} combinations - neither equals {magicalNumbers}");
            else 
                Console.WriteLine(lastCombination);
        }
    }
}

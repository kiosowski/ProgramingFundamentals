﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    for (int k = 0; k <= n - 1; k++)
                    {
                        char letter = (char)('a' + i);
                        char letter1 = (char)('a' + j);
                        char letter2 = (char)('a' + k);
                        Console.WriteLine($"{letter}{letter1}{letter2}");
                    }

                }
            }
        }
    }
}

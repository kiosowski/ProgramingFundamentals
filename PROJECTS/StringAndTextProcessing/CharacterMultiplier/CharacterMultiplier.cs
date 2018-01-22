﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string lineOne = input[0];
            string lineTwo = input[1];

            int minL = Math.Min(lineOne.Length, lineTwo.Length);
            int sum = 0;

            for (int i = minL - 1; i >= 0; i--)
            {
                sum += lineTwo[i] * lineOne[i];
            }
            string rest = "";
            if (lineOne.Length > lineTwo.Length)
            {
                rest = lineOne.Substring(minL);
            }
            else
            {
                rest = lineTwo.Substring(minL);
            }
            foreach (char ch in rest)
            {
                sum += ch;
            }
            Console.WriteLine(sum);
        }
    }
}

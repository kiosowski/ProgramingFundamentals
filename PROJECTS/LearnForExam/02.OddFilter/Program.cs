﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).ToList();


            var average = numbers.Average();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    numbers[i] += 1;
                }
                else if (numbers[i] <= average)
                {
                    numbers[i] -= 1;
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
    
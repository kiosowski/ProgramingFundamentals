﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] nums =
                   Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();
            int counter = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (nums.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", nums[i], nums[j], sum);
                        counter++;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}

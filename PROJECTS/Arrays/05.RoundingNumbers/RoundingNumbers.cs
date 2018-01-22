using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] nums =
                   Console.ReadLine()
                   .Split(' ')
                   .Select(double.Parse)
                   .ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                double rounded = Math.Round(nums[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {rounded}");
            }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] nums =
                   Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();
            int[] sum = new int[ nums.Length];
            int k = int.Parse(Console.ReadLine());
          

            for (int i = 0; i < k; i++)
            {
                int[] rotated = new int[nums.Length];
                rotated[0] = nums[nums.Length - 1];
                for (int j = 1; j < rotated.Length; j++)
                {
                    rotated[j] = nums[j - 1];
                }

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += rotated[j];
                }

                nums = rotated;
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
           

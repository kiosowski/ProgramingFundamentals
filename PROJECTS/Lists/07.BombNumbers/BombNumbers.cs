using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class BombNumbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int bomb = input[0];
            int bombRange = input[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int leftindex = Math.Max(i - bombRange, 0);
                    int rightindex = Math.Min(i + bombRange, numbers.Count - 1);

                    numbers.RemoveRange(i, rightindex - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(leftindex, i - leftindex);
                    i = 0;
                }

            }
            Console.WriteLine(string.Join("", numbers.Sum()));
            


        }
    }
}





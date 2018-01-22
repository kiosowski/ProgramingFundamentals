using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] number = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
                if (number.Length == 1)
                {
                    File.WriteAllText("output.txt", "0");
                    return;
                }
                sumLeft = 0;
                for (int iLeft = i; iLeft > 0; iLeft--)
                {
                    int nextPosition = iLeft - 1;
                    if (iLeft > 0)
                    {
                        sumLeft += number[nextPosition];
                    }
                }

                sumRight = 0;
                for (int iRight = i; iRight < number.Length; iRight++)
                {
                    int nextPosition = (iRight + 1);
                    if (iRight < number.Length - 1)
                    {
                        sumRight += number[nextPosition];
                    }
                }

                if (sumLeft == sumRight)
                {
                    File.WriteAllText("output.txt", i.ToString());
                    return;
                }

            }
            File.WriteAllText("output.txt", "no");
        }
    }
}
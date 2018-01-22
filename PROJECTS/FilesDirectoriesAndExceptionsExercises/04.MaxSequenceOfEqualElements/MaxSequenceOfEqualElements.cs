using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _04.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] input = File.ReadAllText("input.txt")
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int maxStart = 0;
            int maxLen = 1;
            int currentStart = 0;
            int currentLen = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[currentStart])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentLen = 1;
                    currentStart = i;
                }
            }
            File.Delete("output.txt");
            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                
                File.AppendAllText("output.txt", input[i].ToString()+ " ");
            }
        }
    }
}
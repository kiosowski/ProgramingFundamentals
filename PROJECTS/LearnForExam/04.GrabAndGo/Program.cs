using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var number = int.Parse(Console.ReadLine());

            var sumOfElements = 0L;
            var numberExists = false;
            var lastOccurence = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentNumber = input[i];
                if (currentNumber.Equals(number))
                {
                    numberExists = true;
                    lastOccurence = i;
                }
            }
            if (numberExists)
            {
                sumOfElements = input.Take(lastOccurence).Sum();
                Console.WriteLine(sumOfElements);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            var sortedDict = new SortedDictionary<double, int>();
            foreach (var i in input)
            {
                if (sortedDict.ContainsKey(i))
                {
                    sortedDict[i]++;
                }
                else
                {
                    sortedDict[i] = 1;
                }
            }

            foreach (var dict in sortedDict.Keys)
            {
                Console.WriteLine($"{dict} -> {sortedDict[dict]}");
            }

        }
    }
}

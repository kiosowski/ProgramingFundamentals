using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var evenOrOdd = Console.ReadLine();
            var linesCount = int.Parse(Console.ReadLine());

            var words = new List<string>();

            for (int i = 1; i <= linesCount; i++)
            {
                var isEven = ((i % 2).Equals(0));
                var isOdd = (!(i % 2).Equals(0));

                var currentWord = Console.ReadLine();

                if (evenOrOdd == "even" && isEven)
                {
                    words.Add(currentWord);
                }

                else if (evenOrOdd == "odd" && isOdd)
                {
                    words.Add(currentWord);
                }
            }

            Console.WriteLine(string.Join(delimiter, words));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesCount = int.Parse(Console.ReadLine());

            var openingBracket = "(";
            var closingBracket = ")";

            var bracketsCount = 0;

            var previousString = string.Empty;
            var lastBracket = string.Empty;

            var isBalanced = true;

            for (int i = 0; i < linesCount; i++)
            {
                var currentString = Console.ReadLine();

                if (currentString.Equals(openingBracket) || currentString.Equals(closingBracket))
                {
                    bracketsCount++;

                    lastBracket = currentString;

                    if (currentString == previousString)
                    {
                        isBalanced = false;
                        break;
                    }

                }

                previousString = currentString;
            }

            var notRepeated = (bracketsCount % 2 == 0);
            var lastBracketNotOpenening = lastBracket != openingBracket;

            var result = (isBalanced && notRepeated && lastBracketNotOpenening) ? "BALANCED" : "UNBALANCED";

            Console.WriteLine(result);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            var a = Math.Abs(int.Parse(Console.ReadLine()));
            var b = Math.Abs(int.Parse(Console.ReadLine()));
            var magicNumber = Math.Abs(int.Parse(Console.ReadLine()));
            var sum = 0;
            var totalCombinations = 0;
            var isMagicNumber = false;


            for (int i = a; i >= 1; i--)
            {
                for (int j = 1; j <= b; j++)
                {
                    if (sum >= magicNumber)
                    {
                        isMagicNumber = true;
                        break;
                    }
                    else
                    {
                        totalCombinations++;
                        sum += 3 * (i * j);
                    }
                }
                if (sum >= magicNumber)
                {
                    isMagicNumber = true;
                    break;
                }
            }

            Console.WriteLine("{0} combinations", totalCombinations);

            if (isMagicNumber)
            {
                Console.WriteLine("Sum: {0} >= {1}", sum, magicNumber);
            }
            else
            {
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}
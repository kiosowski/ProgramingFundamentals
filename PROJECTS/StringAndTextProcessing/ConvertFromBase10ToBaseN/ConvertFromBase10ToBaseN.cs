using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace ConvertFromBase10ToBaseN
{
    class ConvertFromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var baseN = int.Parse(input[0]);
            var baseTen = BigInteger.Parse(input[1]);
            var result = ConvertFrom10ToN(baseTen, baseN);
            Console.WriteLine(result);
           
        }

        private static object ConvertFrom10ToN(BigInteger baseTen, int baseN)
        {
            var result = string.Empty;
            while (baseTen > 0)
            {
                var remainder = baseTen % baseN;
                result = remainder + result;
                baseTen /= baseN;
            }
            return result;
        }
    }
}

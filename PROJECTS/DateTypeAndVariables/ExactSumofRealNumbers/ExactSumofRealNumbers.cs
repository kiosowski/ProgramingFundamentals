using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumofRealNumbers
{
    class ExactSumofRealNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal number;
            decimal sum = 0M;
            for (int i = 0; i < n; i++)
            {
                number = decimal.Parse(Console.ReadLine());

                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}

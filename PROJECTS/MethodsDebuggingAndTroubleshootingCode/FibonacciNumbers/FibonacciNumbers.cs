using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            FibonacciNumber(n);

        }
        static void FibonacciNumber(int n)
        {
            var f0 = 1;
            var f1 = 1;
            for (var i = 0; i < n - 1; i++)
            {
                var fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            Console.WriteLine(f1);
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingOfIntegerNumber
{
    class SignOfIntNum
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        static void PrintSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");

            }
        }
    }
}

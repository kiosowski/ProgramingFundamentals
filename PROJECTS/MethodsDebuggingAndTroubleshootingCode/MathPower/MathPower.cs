using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var p = double.Parse(Console.ReadLine());
            Console.WriteLine(CalcPower(n,p));
        }
        static double CalcPower(double n, double p)
        {
            double result = 1;
            for (double i = 1; i <= p; i++)
            {
                result = result * n;
            }
            return result;
            
        }
    }
}

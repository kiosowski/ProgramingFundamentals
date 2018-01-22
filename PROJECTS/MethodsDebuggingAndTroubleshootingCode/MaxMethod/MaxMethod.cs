using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(GetMax(n1,n2),n3));
        }
        static int GetMax(int a, int b)
        {
            var max = Math.Max(a, b);
            return max;
        }
    }
}

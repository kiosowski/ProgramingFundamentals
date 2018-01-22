using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            if (input == "face")
            {
                Console.WriteLine($"{Face(n):F2}");
                
            }
            else if (input == "volume")
            {
                Console.WriteLine($"{Volume(n):F2}");
            }
            else if (input == "space")
            {
                Console.WriteLine($"{Space(n):F2}");
            }
            else if (input == "area")
            {
                Console.WriteLine($"{Area(n):F2}");
            }

        }
        static double Face(double n)
        {
            return Math.Sqrt(2 * (n * n));
        }
        static double Space(double n)
        {
            return Math.Sqrt(3 * (n * n));
        }
        static double Volume(double n)
        {
            return Math.Pow(n,3);
        }
        static double Area(double n)
        {

            return 6 * Math.Pow(n, 2);
            
        }
    }
}

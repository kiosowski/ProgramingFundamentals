using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKm
{
    class MilesToKm
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());

            var milesToKm = miles * 1.60934;

            Console.WriteLine("{0:f2}",milesToKm);
        }
    }
}

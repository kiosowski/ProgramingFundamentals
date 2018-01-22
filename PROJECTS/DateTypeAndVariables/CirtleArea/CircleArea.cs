using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirtleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F12}",radius * radius * Math.PI);
        }
    }
}

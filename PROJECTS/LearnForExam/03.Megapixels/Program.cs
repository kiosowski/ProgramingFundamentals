using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var result = width * height;
            var finalResult = Math.Round(result / 1000000,1);
            Console.WriteLine("{0}x{1} => {2}MP",width,height,finalResult);
           
        }
    }
}

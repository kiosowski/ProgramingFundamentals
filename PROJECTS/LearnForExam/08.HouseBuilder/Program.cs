using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = long.Parse(Console.ReadLine());
            var secNum = long.Parse(Console.ReadLine());


            if (firstNum < secNum)
            {
                var firstResult = firstNum * 4;
                var secResult = secNum * 10;
                var finalResult = firstResult + secResult;
                Console.WriteLine(finalResult);
            }
            else
            {
                var firstResult = firstNum * 10;
                var secResult = secNum * 4;
                var finalResult = firstResult + secResult;
                Console.WriteLine(finalResult);
            }
          
        }
    }
}

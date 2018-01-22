using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegative
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToList();
            
            while (numbers[0] < 0)
            {
                
                Console.WriteLine("empty");
                break;
            }
            numbers.RemoveAll(n => n < 0);


            numbers.Reverse();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}

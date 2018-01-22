using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var spaceAfterInput = input - 2;
            for (int i = 0; i < input / 2; i++, spaceAfterInput -= 2)
            {
                Console.WriteLine($"{new string(' ', i)}x{new string(' ', spaceAfterInput)}x");
            }
            Console.WriteLine($"{new string(' ', input / 2)}x");
            spaceAfterInput = 1;
            for (int i = input / 2; i > 0; i--, spaceAfterInput += 2)
            {
                Console.WriteLine($"{new string(' ', i - 1)}x{new string(' ', spaceAfterInput)}x");
            }
        }
    }
}

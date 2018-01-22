using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower()
            .Split(' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?')
            .Where(i => i != "").Where(i => i.Length < 5).OrderBy(i => i).Distinct()
            .ToArray();

            
            Console.WriteLine(string.Join(", ",input));




        }
    }
}

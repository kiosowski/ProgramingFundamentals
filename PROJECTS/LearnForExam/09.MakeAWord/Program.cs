using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var word = String.Empty;
            for (int i = 0; i < n; i++)
            {
                
                char letter = char.Parse(Console.ReadLine());
                word = word + letter;
                
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}

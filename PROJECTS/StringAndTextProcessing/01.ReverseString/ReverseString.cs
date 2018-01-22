using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] reversed = input.ToCharArray().Reverse().ToArray();
            
            Console.WriteLine(String.Join("",reversed));
            
        }
    }
}

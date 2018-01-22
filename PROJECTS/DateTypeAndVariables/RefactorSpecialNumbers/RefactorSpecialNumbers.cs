using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            int c = 0;
            bool d = false;
            for (int ch = 1; ch <= a; ch++)
            {
                c = ch;
                while (ch > 0)
                {
                    b += ch % 10;
                    ch = ch / 10;
                }
                d = (b == 5) || (b == 7) || (b == 11);
                Console.WriteLine($"{c} -> {d}");
                b = 0;
                ch = c;
            }

        }
    }
}

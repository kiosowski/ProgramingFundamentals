using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class ASCII
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            for (int i = from; i <= to; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();

        }
    }
}

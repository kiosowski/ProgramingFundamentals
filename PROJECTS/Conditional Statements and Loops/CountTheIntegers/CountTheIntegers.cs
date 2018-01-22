using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            var number = 0;
            try
            {
                while (true)
                {
                    int.Parse(Console.ReadLine());
                    number++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(number);
            }
        }
    }
}

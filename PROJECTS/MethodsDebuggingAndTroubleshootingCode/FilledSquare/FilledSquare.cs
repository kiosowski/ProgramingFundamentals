using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledSquare
{
    class FilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Header(n);

            MiddleRow(n);
            Header(n);


        }
        static void Header(int n)
        {
            Console.WriteLine(new string('-', 2*n));
        }
        static void MiddleRow(int n)
        {
            for (int j = 0; j < n -2; j++)
            {
                Console.Write('-');
                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
            
        }
    }
}

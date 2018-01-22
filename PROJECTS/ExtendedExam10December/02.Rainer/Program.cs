using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> field = new List<int>(sequence.Reverse().Skip(1).Reverse());
            List<int> originalField = new List<int>(field);

            var donaldIndex = sequence.Last();
            var stepsDone = 0;

            while (true)
            {
                field = field.Select(x => x -1).ToList();
                stepsDone++;
            }
         
        }
    }
}
    
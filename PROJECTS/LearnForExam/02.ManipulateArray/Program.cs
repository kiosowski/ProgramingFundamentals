using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Distinct")
                {
                    var result = arr.Distinct();
                }
                if (command[0] == "Reverse")
                {
                    var result1 = arr.Reverse();
                }
                if (command[0] == "Replace")
                {
                    var index = int.Parse(command[1]);
                    var replaceItem = command[2];

                    arr[index] = replaceItem;
                }
            }
            Console.WriteLine(string.Join(", ",arr));
        }
    }
}

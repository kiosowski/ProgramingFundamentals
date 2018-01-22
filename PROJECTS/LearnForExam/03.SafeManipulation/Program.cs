using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            var line = Console.ReadLine();

            while (!line.Equals("END"))
            {
                var command = line.Split();

                switch (command[0])
                {
                    case "Reverse":
                        arr = arr.Reverse().ToArray();
                        break;
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Replace":
                        var index = int.Parse(command[1]);
                        var replaceItem = command[2];
                        if (index < 0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        arr[index] = replaceItem;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
                line = Console.ReadLine();
            }
         
            Console.WriteLine(string.Join(", ", arr));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var years = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName} {lastName}. You Are {years} years old.");
        }
    }
}

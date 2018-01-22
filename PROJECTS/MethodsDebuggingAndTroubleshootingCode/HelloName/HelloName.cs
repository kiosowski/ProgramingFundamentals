using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Console.WriteLine((Name(name)));
        }
        static string Name(string name)
        {
            name = "Hello, " + name + "!";
            return name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] camera = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            var pattern = @"\|<\w+";
            var matchesText = Regex.Matches(input, pattern);
            List<string> outputList = new List<string>();
            foreach (Match match in matchesText)
            {
               
                var output = match.ToString().Skip(camera[0] + 2).Take(camera[1]);

                outputList.Add(string.Join("",output));

            }
            Console.WriteLine(string.Join(", ",outputList));
        }
    }
}

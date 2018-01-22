using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Join(" ",inputData));
            
            while (true)
            {
                var inputLines = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var mergeOrDivide = inputLines[0];
                if (mergeOrDivide == "3:1")
                {
                    break;
                }
                var startIndex = int.Parse(inputLines[1]);
                var endIndex = int.Parse(inputLines[2]);


                if (mergeOrDivide == "merge")
                {
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        sb.Append(inputData[i]);

                    }
                }
                if (mergeOrDivide == "divide")
                {
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        
                    }
                }

            }
            Console.WriteLine(string.Join("",inputData));
        }
    }
}
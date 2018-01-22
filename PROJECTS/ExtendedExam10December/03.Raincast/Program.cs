using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.RainCast
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputArr;
            var myList = new List<string>();

            var forecastChars = new List<char>(new char[] { '!', '.', ','});


            while ((inputArr = Console.ReadLine()) != "Davai Emo")
            {
                var input = inputArr;

                myList.Add(input);
            }

            var type = false;
            var source = false;
            var forecast1 = false;

            StringBuilder print = new StringBuilder();
            StringBuilder sourceHolder = new StringBuilder();

            foreach (var forecast in myList)
            {

                var splited = forecast.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);

                var token = splited[0];
                var token2 = splited[1];

                if (!type && !source && !forecast1)
                {
                    if (token == "Type" && (token2 == "Normal" || token2 == "Warning" || token2 == "Danger"))
                    {
                        print.Append("(" + token2 + ") ");
                        type = true;
                    }
                }
                if (type && !source && !forecast1)
                {
                    
                    if (token == "Source")
                    {
                        
                        sourceHolder.Append(" ~ " + token2);
                        source = true;
                    }
                }
                if (type && source && !forecast1)
                {
                    if (token == "Forecast" && !token.Any(s => forecastChars.Contains(s)))
                    {
                        
                        print.Append(token2);
                        type = false;
                        source = false;
                        forecast1 = false;
                        print.Append(sourceHolder);
                        Console.WriteLine(print);
                        sourceHolder.Clear();
                        print.Clear();
                    }
                }
            }
        }
      
    }

}





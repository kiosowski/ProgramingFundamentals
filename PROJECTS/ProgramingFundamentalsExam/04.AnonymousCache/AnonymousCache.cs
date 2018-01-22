using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AnonymousCache
{
    class AnonymousCache
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<int, string>> dataDict =
                new Dictionary<string, Dictionary<int, string>>();

            string[] input = Console.ReadLine().Split(new string[] { " -> ", " | " }
                , StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "thetinggoesskrra")
            {
                input = Console.ReadLine().Split(new string[] { " -> ", " | " }
                , StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input.Length == 1)
                {
                    var dataSet = input[0];
                    dataDict[dataSet] = new Dictionary<int, string>();
                }
                else
                {
                    string dataKey = input[0];
                    int dataSize = int.Parse(input[1]);
                    string dataSet = input[2];
                    if (dataDict.ContainsKey(dataSet))
                    {
                        dataDict[dataSet].Add(dataSize, dataKey);
                    }
                    else
                    {
                        dataDict[dataSet] = new Dictionary<int, string>();
                        dataDict[dataSet].Add(dataSize, dataKey);
                    }
                    
                }
            }
          
        }
    }
}

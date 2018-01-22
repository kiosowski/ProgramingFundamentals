using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();       
            Dictionary<string, long> result = new Dictionary<string, long>();
            while (resource != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());
                if (result.ContainsKey(resource))
                {
                    result[resource] += quantity;
                }
                else
                {
                    result[resource] = quantity;
                }
                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
            }
            foreach (var re in result)
            {
                Console.WriteLine("{0} -> {1}", re.Key, re.Value);
            }
        }
    }
}

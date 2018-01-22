using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<int>>();

            string inputArgs = string.Empty;

            while ((inputArgs = Console.ReadLine()) != "I believe I can fly!")
            {
                if (!inputArgs.Contains(" = "))
                {
                    var input = inputArgs.Split();

                    var customer = input.First();
                    var flights = input.Skip(1).Take(input.Length - 1).Select(int.Parse).ToList();

                    if (!data.ContainsKey(customer))
                    {
                        data[customer] = new List<int>();
                    }
                    data[customer].AddRange(flights);

                }
                else
                {
                    
                    var input = inputArgs.Split(new[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
                    var firstCustomer = input[0];
                    var SecondCustomer = input[1];

                    if (!data.ContainsKey(SecondCustomer))
                    {
                        data[firstCustomer] = new List<int>();
                    }
                    data[firstCustomer].Clear();
                    data[firstCustomer].AddRange(data[SecondCustomer]);

                }
            }
            foreach (var a in data.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                Console.WriteLine($"#{a.Key} ::: {string.Join(", ", a.Value.OrderBy(x => x))}");
            }
        }
    }
}


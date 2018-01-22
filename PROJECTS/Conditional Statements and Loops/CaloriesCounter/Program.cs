using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string ingredients;
            var callories = 0;
            for (int i = 0; i < n; i++)
            {
                ingredients = Console.ReadLine().ToLower();
                if (ingredients == "tomato sauce")
                {
                    callories += 150;
                }
                if (ingredients == "cheese")
                {
                    callories += 500;
                }
                if (ingredients == "salami")
                {
                    callories += 600;
                }
                if (ingredients == "pepper")
                {
                    callories += 50;
                }
               
            }
            Console.WriteLine($"Total calories: {callories}");
        }
    }
}

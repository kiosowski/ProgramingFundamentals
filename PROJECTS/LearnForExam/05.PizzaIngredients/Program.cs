using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().Split().ToArray();
            var length = long.Parse(Console.ReadLine());
           
            List<string> result = new List<string>();
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == length)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                
                    result.Add(ingredients[i]);
                    
                }
                if (result.Count >= 10)
                {
                    break;
                }



            }
            Console.WriteLine($"Made pizza with total of {result.Count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",result)}.");
            
              
            
        }
    }
}

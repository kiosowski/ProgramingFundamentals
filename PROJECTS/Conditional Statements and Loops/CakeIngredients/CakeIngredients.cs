using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var ingredients = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");

                input = Console.ReadLine();
                ingredients++;
            
                    
            }
            Console.WriteLine($"Preparing cake with {ingredients} ingredients.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            double hallprice = 0.0;

            if (groupSize >= 1 && groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                hallprice = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                hallprice = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                hallprice = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            if (groupSize < 120)
            {
                if (package == "Normal")
                {
                    hallprice += 500;
                    hallprice = hallprice * 0.95;
                }
                else if (package == "Gold")
                {
                    hallprice += 750;
                    hallprice = hallprice * 0.90;
                }
                else if (package == "Platinum")
                {
                    hallprice += 1000;
                    hallprice = hallprice * 0.85;
                }
                var pricePerPerson = hallprice / groupSize;
                Console.WriteLine("The price per person is {0:F2}$",pricePerPerson);
            }


        }
    }
}

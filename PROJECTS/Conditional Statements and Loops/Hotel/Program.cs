using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightCount = int.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0; ;

            if (month == "May" || month == "October")
            {
                studioPrice += 50 * nightCount;
                doublePrice += 65 * nightCount;
                suitePrice += 75 * nightCount;
                if (nightCount > 7)
                {
                    studioPrice = studioPrice * 0.95;
                    if (month == "October")
                    {
                        var pricePerNight = studioPrice / nightCount;
                        studioPrice -= pricePerNight;
                    }
                }

            }
            else if (month == "June" || month == "September")
            {
                studioPrice += 60 * nightCount;
                doublePrice += 72 * nightCount;
                suitePrice += 82 * nightCount;
                if (nightCount > 14)
                {
                    doublePrice = doublePrice * 0.90;
                }
                if (month == "September")
                {
                    var pricePerNight = studioPrice / nightCount;
                    studioPrice -= pricePerNight;
                }


            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice += 68 * nightCount;
                doublePrice += 77 * nightCount;
                suitePrice += 89 * nightCount;
                if (nightCount > 14)
                {
                    suitePrice = suitePrice * 0.85;
                }
            }



            Console.WriteLine("Studio: {0:F2} lv.", studioPrice);
            Console.WriteLine("Double: {0:F2} lv.", doublePrice);
            Console.WriteLine("Suite: {0:F2} lv.", suitePrice);
        }
    }
}

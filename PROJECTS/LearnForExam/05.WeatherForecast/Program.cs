using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            var prediction = string.Empty;

            try
            {
                var weather = long.Parse(Console.ReadLine());

                if (weather >= sbyte.MinValue && weather <= sbyte.MaxValue)
                {
                    prediction = "Sunny";
                }

                else if (weather >= int.MinValue && weather <= int.MaxValue)
                {
                    prediction = "Cloudy";
                }

                else
                {
                    prediction = "Windy";
                }
            }

            catch
            {

                prediction = "Rainy";
            }

            Console.WriteLine(prediction);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            
            float totalSeconds = hours * 3600 + minutes * 60 + seconds;
            float metersPerSecond = distanceInMeters / totalSeconds;

            
            float totalHours = hours + minutes / 60 + seconds / 3600;
            float distanceInKilometers = distanceInMeters / 1000;
            float kilometersPerHour = distanceInKilometers / totalHours;

            
            float distanceInMiles = distanceInMeters / 1609;
            float milesPerHour = distanceInMiles / totalHours;

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);


        }
    }
}

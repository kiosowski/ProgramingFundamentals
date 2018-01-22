using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            var imperialUnit = Console.ReadLine();
            var number = double.Parse(Console.ReadLine());

            switch (imperialUnit)
            {
                case "miles":
                    var milesInKm = number * 1.6;
                    Console.WriteLine($"{number} {imperialUnit} = {milesInKm:f2} kilometers");
                    break;
                case "inches":
                    var inchesInCm = number * 2.54;
                    Console.WriteLine($"{number} {imperialUnit} = {inchesInCm:f2} centimeters");
                    break;
                case "feet":
                    var feetInCm = number * 30;
                    Console.WriteLine($"{number} {imperialUnit} = {feetInCm:f2} centimeters");
                    break;
                case "yards":
                    var yardsInMetres = number * 0.91;
                    Console.WriteLine($"{number} {imperialUnit} = {yardsInMetres:f2} meters");
                    break;
                case "gallons":
                    var gallonsInLitters = number * 3.8;
                    Console.WriteLine($"{number} {imperialUnit} = {gallonsInLitters:f2} liters");
                    break;
                default:
                    break;
            }
        }
    }
}

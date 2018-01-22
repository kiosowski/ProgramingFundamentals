using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());

            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var size = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            PrintPictureName(photoNumber);
            PrintDateAndTime(day,month,year,hours,minutes);
            PrintSize(size);
            PrintResolution(width,height);


        }

        private static void PrintResolution(int width,int height)
        {
            if (width>height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (height>width)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }

        private static void PrintSize(int size)
        {
            if (size >= 1000000)
            {
                Console.WriteLine($"Size: {size/1000000.0}MB");
            }
            else if (size >= 1000)
            {
                Console.WriteLine($"Size: {size/1000}KB");
            }
            else if (size < 1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
        }

        private static void PrintDateAndTime(int day,int month,int year,int hours,int minutes)
        {
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2}");
        }

        private static void PrintPictureName(int photoNumber)
        {
            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
        }
    }
}

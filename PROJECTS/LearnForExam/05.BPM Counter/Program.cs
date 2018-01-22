using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var beatsPerMinute = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());

            var bar = 4.0;

            var bars = Math.Round((numberOfBeats / bar), 1);
            int totalTime = (int)(numberOfBeats / beatsPerMinute * 60);

            var minutes = totalTime / 60;
            var seconds = totalTime % 60;

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}

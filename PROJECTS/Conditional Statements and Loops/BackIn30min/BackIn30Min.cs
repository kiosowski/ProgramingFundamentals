using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30min
{
    class BackIn30Min
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var finalminutes = minutes + 30;
            if (finalminutes > 59)
            {
                hours += 1;
                finalminutes -= 60;

            }
            if (hours >= 24)
            {
                hours -= 24;
            }
         
           
             Console.WriteLine("{0}:{1:D2}", hours, finalminutes);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeralType = Console.ReadLine();
            var idsCount = int.Parse(Console.ReadLine());

            var maxValue = 0l;

            var thiefsID = long.MinValue;

            for (int i = 0; i < idsCount; i++)
            {
                var currentID = long.Parse(Console.ReadLine());

                switch (numeralType)
                {
                    case "sbyte":
                        thiefsID = SByteTypeID(ref thiefsID, currentID);
                        break;

                    case "int":
                        thiefsID = IntTypeID(ref thiefsID, currentID);
                        break;

                    case "long":
                        thiefsID = LongTypeID(ref thiefsID, currentID);
                        break;
                }
            }

            Console.WriteLine(thiefsID);
        }

        private static long SByteTypeID(ref long thiefsID, long currentID)
        {
            long maxValue = sbyte.MaxValue;

            if (currentID > thiefsID && currentID <= maxValue)
            {
                thiefsID = currentID;
            }

            return thiefsID;
        }

        private static long IntTypeID(ref long thiefsID, long currentID)
        {
            long maxValue = int.MaxValue;

            if (currentID > thiefsID && currentID <= maxValue)
            {
                thiefsID = currentID;
            }

            return thiefsID;
        }

        private static long LongTypeID(ref long thiefsID, long currentID)
        {
            long maxValue = long.MaxValue;

            if (currentID > thiefsID && currentID <= maxValue)
            {
                thiefsID = currentID;
            }

            return thiefsID;
        }
    }
}
   
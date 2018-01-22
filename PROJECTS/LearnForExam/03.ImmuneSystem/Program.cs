using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var viruses = new List<string>();
            var initialHealth = int.Parse(Console.ReadLine());
            var virusName = Console.ReadLine();
            var maxInitialHealth = initialHealth;
            var isImmuneSystemDefeated = false;

            while (!virusName.Equals("end"))
            {
                var virusStrenght = CalculateVirusStrength(virusName);
                var virusNameLength = virusName.Length;

                var defeatTimeInSeconds = virusStrenght * virusNameLength;

                if (!viruses.Contains(virusName))
                {
                    viruses.Add(virusName);
                }
                else
                {
                    defeatTimeInSeconds /= 3;
                }
                var defeatMinutes = defeatTimeInSeconds / 60;
                var defeatSeconds = defeatTimeInSeconds % 60;
                Console.WriteLine($"Virus {virusName}: {virusStrenght} => {defeatTimeInSeconds} seconds");

                initialHealth -= defeatTimeInSeconds;

                if (initialHealth <= 0)
                {
                    isImmuneSystemDefeated = true;
                    break;
                }
                Console.WriteLine($"{virusName} defeated in {defeatMinutes}m {defeatSeconds}s.");
                Console.WriteLine($"Remaining health: {initialHealth}");

                initialHealth = Math.Min((int)(initialHealth * 1.2), maxInitialHealth);

                virusName = Console.ReadLine();
            }
            if (isImmuneSystemDefeated)
            {
                Console.WriteLine("Immune System Defeated.");
            }
            else
            {
                Console.WriteLine($"Final Health: {initialHealth}");

            }
        }

        private static int CalculateVirusStrength(string virusName)
        {
            var virusStrength = 0;

            foreach (var character in virusName)
            {
                virusStrength += character;
            }
            return virusStrength / 3;
        }
    }
}

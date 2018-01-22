using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBoatCharacter = char.Parse(Console.ReadLine());
            var secondBoatCharacter = char.Parse(Console.ReadLine());
            var linesCount = int.Parse(Console.ReadLine());

            var firstBoatSpeed = 0;
            var secondBoatSpeed = 0;

            var winner = '\0';

            var reachedFiftyMoves = false;

            for (int i = 1; i <= linesCount; i++)
            {
                var command = Console.ReadLine();

                var oddLine = i % 2 != 0;

                if (oddLine)
                {
                    firstBoatSpeed += command.Length;
                }

                else
                {
                    secondBoatSpeed += command.Length;
                }

                if (command.Equals("UPGRADE"))
                {
                    firstBoatCharacter += (char)3;
                    secondBoatCharacter += (char)3;
                }

                if (firstBoatSpeed >= 50)
                {
                    reachedFiftyMoves = true;
                    winner = firstBoatCharacter;
                    break;
                }

                else if (secondBoatSpeed >= 50)
                {
                    reachedFiftyMoves = true;
                    winner = secondBoatCharacter;
                    break;
                }
            }

            if (reachedFiftyMoves)
            {
                Console.WriteLine(winner);
            }

            else
            {
                if (firstBoatSpeed > secondBoatSpeed)
                {
                    Console.WriteLine(firstBoatCharacter);
                }

                else
                {
                    Console.WriteLine(secondBoatCharacter);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var charactersCount = int.Parse(Console.ReadLine());

            var decryptedMessage = string.Empty;

            for (int i = 0; i < charactersCount; i++)
            {
                var currentLetter = char.Parse(Console.ReadLine()) + key;

                decryptedMessage += (char)currentLetter;
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
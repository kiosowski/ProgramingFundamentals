using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var badWords = Console.ReadLine().Split(',', ' ').Where(w => w.Length > 0).ToArray();
            var text = Console.ReadLine();

            foreach (var badWord in badWords)
            {
                var replacement = (new string('*',badWord.Length));
                text = text.Replace(badWord, replacement);
            }
            Console.WriteLine(text);
        }
    }
}

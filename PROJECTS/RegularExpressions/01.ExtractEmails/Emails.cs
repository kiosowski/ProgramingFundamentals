using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtractEmails
{
    class Emails
    {
        static void Main(string[] args)
        {
            string regex = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";
            string emails = Console.ReadLine();
            var matchedEmails = Regex.Matches(emails,regex);
            foreach (Match email in matchedEmails)
            {
                Console.WriteLine(email);
            }
            
        }
    }
}

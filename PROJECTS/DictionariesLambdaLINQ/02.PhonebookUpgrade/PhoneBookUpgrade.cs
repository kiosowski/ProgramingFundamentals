using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhoneBookUpgrade
{
    class PhoneBookUpgrade
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var phoneBook = new Dictionary<string, string>();

            while (command != "END")
            {
                string[] splitedCommands = command.Split(' ').ToArray();
                if (splitedCommands[0] == "S")
                {
                    if (!phoneBook.ContainsKey(splitedCommands[1]))
                    {
                        Console.WriteLine("Contact {0} does not exist.", splitedCommands[1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", splitedCommands[1], phoneBook[splitedCommands[1]]);
                    }
                }
                else if(splitedCommands[0] == "A")
                {
                    phoneBook[splitedCommands[1]] = splitedCommands[2];
                }
                else if(splitedCommands[0] == "ListAll")
                {
                    foreach (var phone in phoneBook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine("{0} -> {1}",phone.Key,phone.Value);
                    }
                }
                command = Console.ReadLine();
            }
           
            
        }
    }
}
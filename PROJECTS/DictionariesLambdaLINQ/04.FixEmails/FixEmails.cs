using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, string> dict = new Dictionary<string, string>();
            while (true)
            {
                string name = Console.ReadLine();
                               
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                if (email.Contains("uk") || email.Contains("us"))
                {
                    dict.Remove(name);
                    dict.Remove(email);
                }
                dict[name] = email;
               
            }
            foreach (var re in dict)
            {
                Console.WriteLine("{0} -> {1}", re.Key, re.Value);
            }
        }
    }
}

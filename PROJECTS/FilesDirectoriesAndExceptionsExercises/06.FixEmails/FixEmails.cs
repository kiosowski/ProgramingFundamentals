using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {

            File.Delete("output.txt");
            var lines = File.ReadAllLines("input.txt");
            for (int i = 0; i < lines.Length; i = i + 2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }
                var name = lines[i];
                var email = lines[i + 1];
                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }
                var output = $"{name} -> {email}";
                
                File.AppendAllText("output.txt", output+Environment.NewLine);



            }
        }
    }
}


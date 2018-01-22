﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var curHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var curEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Health: |{0}{1}|", new string('|', curHealth), new string('.',maxHealth-curHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', curEnergy), new string('.', maxEnergy - curEnergy));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AMinerTask
{
    class AMinerTask
    {
        
        static void Main(string[] args)
        {
            Dictionary<string, long> resources = AvalableResources();
            ResourcesToFile(resources);
            

        }
        public static void ResourcesToFile(Dictionary<string, long> resources)
        {
            string result = null;
            foreach (KeyValuePair<string, long> resource in resources)
            {
                result += $"{resource.Key} -> {resource.Value}{Environment.NewLine}";
            }
            File.WriteAllText("output.txt", result);
        }
        private static Dictionary<string, long> AvalableResources()
        {
            string[] data = File.ReadAllLines("input.txt");
            Dictionary<string, long> resources = new Dictionary<string, long>();
            string resourceName = data[0];
            resources[resourceName] = 0;
            for (int i = 1; i < data.Length; i++)
            {
                if (i % 2 == 0)
                {
                    resourceName = data[i];
                    if (!resources.ContainsKey(resourceName))
                    {
                        resources[resourceName] = 0;
                    }
                }
                else
                {
                    resources[resourceName] += long.Parse(data[i]);
                }
            }
            return resources;
        }

    }
}







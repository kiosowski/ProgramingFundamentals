using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            
            int websiteCount = int.Parse(Console.ReadLine());
            int security = int.Parse(Console.ReadLine());
            decimal siteLoss = 0;
            double tokensCount = 0;
            decimal totalLoss = 0;
            List<string> sites = new List<string>();
            for (int i = 0; i < websiteCount; i++)
            {
                string[] data = Console.ReadLine().Split(' ').ToArray();
                tokensCount++;
                sites.Add(data[0]);
                var siteVisits = decimal.Parse(data[1]);
                var sitePricePerVisit = decimal.Parse(data[2]);
                siteLoss = siteVisits * sitePricePerVisit;
                totalLoss += siteLoss;
            }
            foreach (var site in sites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            BigInteger securityToken = BigInteger.Pow(security, sites.Count);
            Console.WriteLine($"Security Token: {securityToken}");

        }
    }
}

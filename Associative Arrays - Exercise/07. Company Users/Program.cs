using System;
using System.Collections.Generic;
namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyInfo =
                new Dictionary<string, List<string>>();


            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split("->");
                string companyName = commandArgs[0];
                string employeId = commandArgs[1];

                if (!companyInfo.ContainsKey(companyName))
                {                     //Key           Value
                    companyInfo[companyName] = new List<string>();
                }
                //Here we are sure that we already have created instance for the value
                if (!companyInfo[companyName].Contains(employeId))
                {
                    companyInfo[companyName].Add(employeId);
                }

            }
            foreach (var kvp in companyInfo)
            {
                string companyName = kvp.Key;
                List<string> employeId = kvp.Value;

                Console.WriteLine($"{companyName}");

                foreach (string employee in employeId)
                {
                    Console.WriteLine($"--{employee}");
                }
            }
        }
    }
}

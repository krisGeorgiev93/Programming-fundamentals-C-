using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friendsNames = Console.ReadLine().Split(", ").ToList();
            List<string> blackList = new List<string>();
            List<string> lostName = new List<string>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] commandArgs = command.Split();
                string commandType = commandArgs[0];
                if (commandType == "Blacklist")
                {
                    string name = commandArgs[1];
                    if (friendsNames.Contains(name))
                    {
                        int index = friendsNames.Select((item, i) => new { Item = item, Index = i })
                .First(x => x.Item == name).Index;
                        Console.WriteLine($"{name} was blacklisted.");
                        blackList.Add(name);
                        friendsNames[index] = "Blacklisted";                        
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                if (commandType == "Error")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index>=0 && index < friendsNames.Count && friendsNames[index] != "Blacklisted" 
                        && friendsNames[index] != "Lost")
                    {
                        lostName.Add(friendsNames[index]);
                        Console.WriteLine($"{friendsNames[index]} was lost due to an error.");
                        friendsNames[index] = "Lost";
                    }
                }
                if (commandType == "Change")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index >= 0 && index < friendsNames.Count)
                    {
                        string newName = commandArgs[2];
                        Console.WriteLine($"{friendsNames[index]} changed his username to {newName}.");
                        friendsNames[index] = newName;
                        
                    }
                }
            }
            Console.WriteLine($"Blacklisted names: {blackList.Count}");
            Console.WriteLine($"Lost names: {lostName.Count}");
            Console.WriteLine(string.Join(" ",friendsNames));
        }
    }
}

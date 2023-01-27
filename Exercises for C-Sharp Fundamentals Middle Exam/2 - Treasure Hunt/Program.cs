using System;
using System.Collections.Generic;
using System.Linq;

namespace _2___Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "Yohoho!" )
            {
                string[] commandArgs = command.Split();
                
                string commandType = commandArgs[0];
                

                if (commandType == "Loot") // когато имаме неопределен брой Items ползваме фор цикъл
                {
                    for (int i = 1; i < commandArgs.Length; i++) 
                    {
                        if (!treasure.Contains(commandArgs[i]))
                        {
                            treasure.Insert(0, commandArgs[i]);
                        }
                    }
                }
                if (commandType == "Drop")
                {
                    int index = int.Parse(commandArgs[1]);
                    
                    if (index <= treasure.Count && index >= 0)
                    {
                        string savedWord = treasure[index];
                        treasure.RemoveAt(index);
                        treasure.Add(savedWord);
                    }
                    
                }
                if (commandType == "Steal")
                {
                    int count = int.Parse(commandArgs[1]);
                    List<string> stealedLoots = new List<string>();
                 
                    
                   if (count < treasure.Count && count >= 0)
                    {
                        for (int i = treasure.Count-count; i < treasure.Count; i++)
                        {
                            stealedLoots.Add(treasure[i]);                          
                        }
                        Console.WriteLine(string.Join(", ", stealedLoots));
                        treasure.RemoveRange(treasure.Count - count, count);
                        stealedLoots.Clear();
                    }
                    else
                    {
                        for (int i = 0; i < treasure.Count; i++)
                        {
                            stealedLoots.Add(treasure[i]);
                        }
                        Console.WriteLine(string.Join(", ", stealedLoots));

                        stealedLoots.Clear(); // !!! Clear the list

                        treasure.RemoveRange(0, treasure.Count);
                    }
                }
            }
            if (treasure.Count>0)
            {
                double sum = 0;
                double avg = 0;
                foreach (var item in treasure)
                {
                    sum += item.Length;
                }
                avg = sum / treasure.Count;
                Console.WriteLine($"Average treasure gain: {avg:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}

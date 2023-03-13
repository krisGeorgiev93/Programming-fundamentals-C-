using System;
using System.Collections.Generic;
using System.Drawing;

namespace Pirates___Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] inputParts = input.Split("||");
                string city = inputParts[0];
                int population = int.Parse(inputParts[1]);
                int gold = int.Parse(inputParts[2]);
                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new List<int>());
                    cities[city].Add(population);
                    cities[city].Add(gold);
                }
                else
                {
                    cities[city][0] += population;
                    cities[city][1] += gold;
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandParts = command.Split("=>");
                string commandType = commandParts[0];
                string town = commandParts[1];

                if (commandType == "Plunder")
                {
                    int peopleKilled = int.Parse(commandParts[2]);
                    int goldStolen = int.Parse(commandParts[3]);

                    cities[town][0] -= peopleKilled;
                    cities[town][1] -= goldStolen;
                    Console.WriteLine($"{town} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                    if (cities[town][0] <= 0 | cities[town][1] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        cities.Remove(town);
                    }
                }
                if (commandType == "Prosper")
                {
                    int gold = int.Parse(commandParts[2]);

                    if (gold <= 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                    }
                }
            }
            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
        }
    }
}

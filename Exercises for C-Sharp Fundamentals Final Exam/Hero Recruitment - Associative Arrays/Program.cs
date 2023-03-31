using System;
using System.Collections.Generic;
using System.Linq;

namespace Hero_Recruitment___Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();
                string commandType = tokens[0];
                string heroName = tokens[1];
                if (commandType == "Enroll")
                {

                    if (heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                    else
                    {
                        heroes.Add(heroName, new List<string>());
                    }
                }
                if (commandType == "Learn")
                {
                    string spellName = tokens[2];
                    if (heroes.ContainsKey(heroName))
                    {
                        if (heroes[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                        else
                        {
                            heroes[heroName].Add(spellName);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
                if (commandType == "Unlearn")
                {
                    string spellName = tokens[2];

                    if (heroes.ContainsKey(heroName))
                    {
                        if (heroes[heroName].Contains(spellName))
                        {
                            heroes[heroName].Remove(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
            }
            Console.WriteLine("Heroes: ");
            foreach (KeyValuePair<string, List<string>> hero in heroes.OrderByDescending(hero => hero.Value.Count).ThenBy(hero => hero.Key))
            {
                Console.Write($"== {hero.Key}: ");
                foreach (var spellname in hero.Value)
                {
                    Console.Write(string.Join(", ", spellname));
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;

namespace Heroes_of_Code_and_Logic_VII___Associative_Arrays
{
    class Program
    {
        public static object Dictionar { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, double[]> heroes = new Dictionary<string, double[]>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
               
                string[] inputPats = input.Split();
                string name = inputPats[0];
                int hp = int.Parse(inputPats[1]);
                int mp = int.Parse(inputPats[2]);
                heroes.Add(name, new double[2]);

                heroes[name][0] = hp;
                heroes[name][1] = mp;

            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandParts = command.Split(" - ");
                string commandName = commandParts[0];
                if (commandName == "CastSpell")
                {
                    string heroName = commandParts[1];
                    int mpNeeded = int.Parse(commandParts[2]);
                    string spellName = commandParts[3];
                    if (heroes[heroName][1] >= mpNeeded)
                    {
                        heroes[heroName][1] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                if (commandName == "TakeDamage")
                {
                    string heroName = commandParts[1];
                    int damage = int.Parse(commandParts[2]);
                    string attacker = commandParts[3];

                    heroes[heroName][0] -= damage;
                    if (heroes[heroName][0] <= 0)
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                    else
                    {                       
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                }
                if (commandName == "Recharge")
                {
                    string heroName = commandParts[1];
                    int amount = int.Parse(commandParts[2]);
                    double oldMp = heroes[heroName][1];

                    heroes[heroName][1] += amount;
                    if (heroes[heroName][1] > 200)
                    {
                        heroes[heroName][1] = 200;
                        Console.WriteLine($"{heroName} recharged for {200 - oldMp} MP!");

                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                if (commandName == "Heal")
                {
                    string heroName = commandParts[1];
                    int amount = int.Parse(commandParts[2]);
                    double oldHp = heroes[heroName][0];

                    heroes[heroName][0] += amount;                    
                 
                    if (heroes[heroName][0] > 100)
                    {
                        heroes[heroName][0] = 100;
                        
                        Console.WriteLine($"{heroName} healed for {100 - oldHp} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }


            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.Write("  HP: ");
                Console.Write(hero.Value[0]);
                Console.WriteLine();
                Console.Write("  MP: ");
                Console.Write(hero.Value[1]);
                Console.WriteLine();

            }


        }
    }
}

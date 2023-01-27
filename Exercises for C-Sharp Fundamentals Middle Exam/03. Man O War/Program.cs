using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            
            int counter = 0;
            string command;

            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] commandArgs = command.Split();
                string commandType = commandArgs[0];

                if (commandType == "Fire")
                {
                    int index = int.Parse(commandArgs[1]);
                    int damage = int.Parse(commandArgs[2]);
                    if (warShip.Count > index && index > 0)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }

                }
                if (commandType == "Defend")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int damage = int.Parse(commandArgs[3]);

                    if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex < pirateShip.Count && endIndex >= 0 && damage > 0)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                if (commandType == "Repair")
                {
                    int index = int.Parse(commandArgs[1]);
                    int health = int.Parse(commandArgs[2]);

                    if (pirateShip.Count > index && index >= 0 && health > 0)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                if (commandType == "Status")
                {
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < (int) maxHealth * 0.20)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine($"{counter} sections need repair.");
                }

            }

            int pirateResult = 0;
            int warResult = 0;

            for (int i = 0; i < pirateShip.Count; i++)
            {
                pirateResult += pirateShip[i];
            }
            Console.WriteLine($"Pirate ship status: {pirateResult}");

            for (int i = 0; i < warShip.Count; i++)
            {
                warResult += warShip[i];

            }

            Console.WriteLine($"Warship status: {warResult}");
        }
    }
}


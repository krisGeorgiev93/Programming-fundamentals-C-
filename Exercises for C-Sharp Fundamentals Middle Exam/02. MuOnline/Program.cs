using System;
using System.Collections.Generic;
using System.Linq;
namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|").ToArray();

            int health = 100;
            int bitcoins = 0;
            int roomsCounter = 0;
            int oldHp = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                string command = rooms[i];
                string[] input = command.Split();
                string commandType = input[0];
                int value = int.Parse(input[1]);
                roomsCounter++;

                if (commandType == "potion")
                {

                    health += value;
                    if (health >= 100)
                    {
                        health = 100;
                        Console.WriteLine($"You healed for {100 - oldHp} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {value} hp.");
                        Console.WriteLine($"Current health: {health} hp.");


                    }
                }
                if (commandType == "chest")
                {


                    bitcoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                if (commandType != "potion" && commandType != "chest")
                {

                    health -= value;
                    oldHp = health;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {commandType}.");
                        Console.WriteLine($"Best room: {roomsCounter}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {commandType}.");
                    }
                }
                if (rooms.Length == roomsCounter)
                {
                    continue;
                }
            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}

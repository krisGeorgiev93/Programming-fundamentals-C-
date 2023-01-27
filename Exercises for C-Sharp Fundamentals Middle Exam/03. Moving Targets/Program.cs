using System;
using System.Collections.Generic;
using System.Linq;
namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split();
                string commandType = commandArgs[0];
                int index = int.Parse(commandArgs[1]);

                if (commandType == "Shoot")
                {
                    int power = int.Parse(commandArgs[2]);
                    if (targets.Count > index && index >= 0)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.Remove(targets[index]);
                        }
                    }
                }
                if (commandType == "Add")
                {
                    int value = int.Parse(commandArgs[2]);

                    if (targets.Count > index && index >= 0)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                if (commandType == "Strike")
                {
//                    "Strike {index} {radius}"
//Remove the target at the given index and the ones before and after it depending on the radius.
//If any of the indices in the range is invalid, print: "Strike missed!" and skip this command.
                    int radius = int.Parse(commandArgs[2]);
                    if (index - radius >= 0 && index + radius < targets.Count) // НАЧИН ЗА НАМИРАНЕ НА RANGE !!!
                    {
                        targets.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }

            }
            Console.WriteLine(string.Join("|", targets));

        }
    }
}


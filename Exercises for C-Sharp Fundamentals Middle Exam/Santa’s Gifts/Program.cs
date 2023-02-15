using System;
using System.Collections.Generic;
using System.Linq;
namespace Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            int lastPosition = 0;
            List<int> houseNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;

            for (int i = 0; i < numOfCommands; i++)
            {
                command = Console.ReadLine();
                string[] commandArgs = command.Split();
                string commandType = commandArgs[0];

                if (commandType == "Forward")
                {
                    int steps = int.Parse(commandArgs[1]);
                    if (steps + lastPosition >= 0 && steps + lastPosition < houseNumbers.Count 
                        && steps < houseNumbers.Count)
                    {
                        houseNumbers.RemoveAt(lastPosition + steps);
                        lastPosition = lastPosition + steps;
                    }
                }
                else if (commandType == "Back")
                {
                    int steps = int.Parse(commandArgs[1]);
                    if (lastPosition - steps >= 0 && lastPosition - steps < houseNumbers.Count 
                        && steps < houseNumbers.Count)
                    {
                        houseNumbers.RemoveAt(lastPosition - steps);
                        lastPosition = lastPosition - steps;
                    }
                }
                else if (commandType == "Gift")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index >= 0 && index < houseNumbers.Count)
                    {
                        int houseNumber = int.Parse(commandArgs[2]);
                        houseNumbers.Insert(index, houseNumber);
                        lastPosition = index;
                    }
                }
                else if (commandType == "Swap")
                {
                    int firstElement = int.Parse(commandArgs[1]);
                    int secondElement = int.Parse(commandArgs[2]);

                    int index1 = houseNumbers.IndexOf(firstElement);
                    int index2 = houseNumbers.IndexOf(secondElement);
                    if (index1 >= 0 && index1 < houseNumbers.Count
                        && index2 >= 0 && index2 < houseNumbers.Count)
                    {
                        int temp = houseNumbers[index1];
                        houseNumbers[index1] = houseNumbers[index2];
                        houseNumbers[index2] = temp;
                    }
                }

            }

            Console.WriteLine($"Position: {lastPosition}");
            Console.WriteLine(string.Join(", ", houseNumbers));


        }
    }
}

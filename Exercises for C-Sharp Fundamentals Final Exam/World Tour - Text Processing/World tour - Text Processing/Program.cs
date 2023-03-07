using System;

namespace World_tour___Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split(" ");
                string commandType = commandParts[0];
                string[] switchParts = command.Split(":");

                if (commandType == "Travel")
                {
                    break;
                }

                if (switchParts[0] == "Switch")
                {
                    string oldString = switchParts[1];
                    string newString = switchParts[2];
                    if (input.Contains(oldString))
                    {
                        input = input.Replace(oldString, newString);
                    }

                    Console.WriteLine(input);
                }
                if (commandType == "Add")
                {
                    string[] commandArgs = commandParts[1].Split(":");
                    int index = int.Parse(commandArgs[1]);
                    string newInput = commandArgs[2];
                    if (index >= 0 && index < input.Length)
                    {
                        input = input.Insert(index, newInput);

                    }

                    Console.WriteLine(input);
                }
                if (commandType == "Remove")
                {
                    string[] commandArgs = commandParts[1].Split(":");
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    if (startIndex >= 0 && startIndex < input.Length && endIndex >= 0 && endIndex < input.Length)
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                    }

                    Console.WriteLine(input);

                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");



        }
    }
}

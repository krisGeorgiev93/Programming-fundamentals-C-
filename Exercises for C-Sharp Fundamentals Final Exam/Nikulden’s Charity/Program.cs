using System;

namespace Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] commandParts = command.Split();
                string commandType = commandParts[0];

                if (commandType == "Replace")
                {
                    string currentChar = commandParts[1];
                    string newChar = commandParts[2];
                    while (input.Contains(currentChar))
                    {
                        input = input.Replace(currentChar, newChar);
                    }
                    Console.WriteLine(input);
                }
                if (commandType == "Cut")
                {
                    int startIndex = int.Parse(commandParts[1]);
                    int endIndex = int.Parse(commandParts[2]);

                    if (startIndex > 0 && startIndex < input.Length && endIndex > 0 & endIndex < input.Length)
                    {
                        input = input.Substring(0, startIndex) + input.Substring(endIndex+1);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                if (commandType == "Make")
                {
                    string upperOrLower = commandParts[1];
                    if (upperOrLower == "Upper")
                    {
                        input = input.ToUpper();
                    }
                    else
                    {
                        input = input.ToLower();
                    }
                    Console.WriteLine(input);
                }
                if (commandType == "Check")
                {
                    string inputPart = commandParts[1];
                    if (input.Contains(inputPart))
                    {
                        Console.WriteLine($"Message contains {inputPart}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {inputPart}");
                    }
                }
                if (commandType == "Sum")
                {
                    int startIndex = int.Parse(commandParts[1]);
                    int endIndex = int.Parse(commandParts[2]);
                    if (startIndex > 0 && startIndex < input.Length && endIndex > 0 & endIndex < input.Length)
                    {
                        string substring = input.Substring(startIndex, endIndex - startIndex+1);
                        int sum = 0;
                        foreach (char ch in substring)
                        {
                            sum += ch;
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }

                }

            }
            Console.WriteLine(input);
        }
    }
}

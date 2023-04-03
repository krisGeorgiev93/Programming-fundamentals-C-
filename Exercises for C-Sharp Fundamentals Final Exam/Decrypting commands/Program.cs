using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace Decrypting_commands
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] tokens = command.Split();
                string commandType = tokens[0];
                if (commandType == "Replace")
                {
                    string currChar = tokens[1];
                    string newCh = tokens[2];
                    input = input.Replace(currChar, newCh);
                    Console.WriteLine(input);
                }
                if (commandType == "Cut")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && startIndex < input.Length && endIndex >= 0 && endIndex < input.Length)
                    {
                        input = input.Substring(0, startIndex) + input.Substring(endIndex+1);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
                if (commandType == "Make")
                {
                    string upperOrLower = tokens[1];
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
                    string key = tokens[1];
                    if (input.Contains(key))
                    {
                        Console.WriteLine($"Message contains {key}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {key}");
                    }
                }
                if (commandType == "Sum")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && startIndex < input.Length && endIndex >= 0 && endIndex < input.Length)
                    {
                        string substring = input.Substring(startIndex, endIndex - startIndex+1);
                        int sum = 0;

                        for (int i = 0; i < substring.Length; i++)
                        {
                            sum += (char)substring[i];
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
            }
        }
    }
}

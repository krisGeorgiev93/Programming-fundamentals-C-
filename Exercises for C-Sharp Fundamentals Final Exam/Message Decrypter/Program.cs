using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(\$|\%)([A-Z][a-z]{2,})\1\:\s(\[(\d+)\])\|(\[(\d+)\])\|(\[(\d+)\])\|$";


            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = regex.Match(command);
                if (match.Success)
                {
                    string tag = match.Groups[2].Value;
                    char firstChar = (char)int.Parse(match.Groups[4].Value);
                    char secondChar = (char)int.Parse(match.Groups[6].Value);
                    char thirdChar = (char)int.Parse(match.Groups[8].Value);

                    char word = firstChar += secondChar += thirdChar;
                    Console.WriteLine($"{tag}: {word}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}

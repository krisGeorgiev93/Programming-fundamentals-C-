using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Message_Translator___Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!(?<command>[A-Z][a-z]{3,})!:\[(?<text>[A-z]{8,})\]";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string text = match.Groups["text"].Value;
                    string command = match.Groups["command"].Value;

                    List<int> encrText = new List<int>();
                    for (int j = 0; j < text.Length; j++)
                    {
                        encrText.Add(text[j]);
                    }
                    Console.WriteLine($"{command}: {string.Join(" ",encrText)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }


            }
        }
    }
}

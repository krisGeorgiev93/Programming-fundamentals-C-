using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Destination_Mapper___Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\=|\/)[A-Z][A-z]{2,}\1";
            List<string> destinations = new List<string>();

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            string word = string.Empty;
            int totalSum = 0;

            foreach (Match curDestination in matchCollection)
            {
                foreach (char ch in curDestination.ToString())
                {
                    if (char.IsLetter(ch))
                    {
                        word += ch;
                    }
                }

                totalSum += word.Length;
                destinations.Add(word);
                word = string.Empty;
            }

            Console.Write("Destinations: ");
            Console.Write(string.Join(", ",destinations));
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {totalSum}");
        }
    }
}

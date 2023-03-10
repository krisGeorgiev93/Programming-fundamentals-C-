using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Emoji_Detector___Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            List<int> numbers = new List<int>();
            List<string> emojies = new List<string>();
            double multiply = 0;
            foreach  (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    numbers.Add(int.Parse(ch.ToString()));
                }
            }
            multiply = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine($"Cool threshold: {multiply}");

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            int letterSum = 0;

            foreach (Match emoji in matchCollection)
            {
                foreach (char ch in emoji.ToString())
                {
                    if (char.IsLetter(ch))
                    {
                        letterSum += (int)ch;
                    }
                }
                if (letterSum>multiply)
                {
                    emojies.Add(emoji.ToString());
                }
                letterSum = 0;
            }
            Console.WriteLine($"{matchCollection.Count} emojis found in the text. The cool ones are:");
            foreach (var item in emojies)
            {
                Console.WriteLine(item);
            }
        }
    }
}

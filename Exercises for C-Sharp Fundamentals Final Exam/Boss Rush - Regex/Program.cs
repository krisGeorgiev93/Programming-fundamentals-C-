using System;
using System.Text.RegularExpressions;

namespace Boss_Rush___Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"\|(?<name>[A-Z]{4,})\|\:\#(?<title>[A-z]+\s[A-z]+)\#";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["name"].ToString();
                    string title = match.Groups["title"].ToString();

                    int strength = name.Length;
                    int armour = title.Length;
                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {strength}");
                    Console.WriteLine($">> Armour: {armour}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}

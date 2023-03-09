using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace text
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var listOfRacers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var dictionaryRacersDistance = new Dictionary<string, int>();
            var regex = new Regex(@"[^_|\W]");

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of race")
            {
                var matches = regex.Matches(input);
                if (regex.IsMatch(input))
                {
                    string racerName = string.Empty;
                    int sumDistance = 0;
                    foreach (Match item in matches)
                    {
                        if (int.TryParse(item.ToString(), out int digit))
                        {
                            sumDistance += digit;
                        }

                        else
                        {
                            racerName += item.ToString();
                        }
                    }

                    if (listOfRacers.Contains(racerName))
                    {
                        if (dictionaryRacersDistance.ContainsKey(racerName) == false)
                        {
                            dictionaryRacersDistance.Add(racerName, sumDistance);
                        }

                        else
                        {
                            dictionaryRacersDistance[racerName] += sumDistance;
                        }
                    }
                }
            }

            var sortedList = dictionaryRacersDistance.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToList();
            Console.WriteLine("1st place: " + sortedList[0]);
            Console.WriteLine("2nd place: " + sortedList[1]);
            Console.WriteLine("3rd place: " + sortedList[2]);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
namespace Nikulden_s_meals___Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int unlikedMeals = 0;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] tokens = command.Split("-");
                string commandType = tokens[0];
                string guest = tokens[1];

                if (commandType == "Like")
                {
                    string meal = tokens[2];

                    if (!guests.ContainsKey(guest))
                    {
                        guests.Add(guest, new List<string>());
                    }
                    if (!guests[guest].Contains(meal))
                    {
                        guests[guest].Add(meal);
                    }
                }
                if (commandType == "Unlike")
                {
                    string meal = tokens[2];
                    if (guests.ContainsKey(guest))
                    {
                        if (guests[guest].Contains(meal))
                        {
                            guests[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            unlikedMeals++;
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }
            }

            foreach (KeyValuePair<string, List<string>> guest in guests.OrderByDescending(guest => guest.Value.Count).ThenBy(guest => guest.Key))
            {
                Console.Write($"{guest.Key}: ");
                Console.Write(string.Join(", ", guest.Value));
                Console.WriteLine();
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}");

        }
    }
}

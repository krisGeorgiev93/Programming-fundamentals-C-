using System;
using System.Collections.Generic;
using System.Linq;

namespace Inbox_Manager___Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = command.Split("->");
                string commandType = tokens[0];
                string username = tokens[1];

                if (commandType == "Add")
                {
                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        users.Add(username, new List<string>());
                    }
                    
                }
                if (commandType == "Send")
                {
                    string email = tokens[2];
                    users[username].Add(email);
                }
                if (commandType == "Delete")
                {
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
            }

            Console.WriteLine($"Users count: {users.Count}");

            foreach (KeyValuePair<string, List<string>> user in users.OrderByDescending(user => user.Value.Count).ThenBy(user => user.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var email in user.Value)
                {
                    Console.WriteLine($" - {email}");
                }
            }
        }
    }
}

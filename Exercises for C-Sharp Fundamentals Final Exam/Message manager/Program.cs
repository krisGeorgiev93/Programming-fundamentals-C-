using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
namespace Message_manager
{
    class Program
    {
        static void Main(string[] args)
       {
            int capacity = int.Parse(Console.ReadLine());

            Dictionary<string, int[]> users = new Dictionary<string, int[]>();

            string command = string.Empty;            
            while ((command = Console.ReadLine()) != "Statistics")
            {
                
                string[] tokens = command.Split("=");
                string commandType = tokens[0];
                if (commandType == "Add")
                {
                    string username = tokens[1];
                    int sent = int.Parse(tokens[2]);
                    int received = int.Parse(tokens[3]);

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new int[2]);
                    }
                    users[username][0] += sent;
                    users[username][1] += received;                  
                   
                }
                if (commandType == "Message")
                {
                    string sender = tokens[1];
                    string receiver = tokens[2];
                    if (users.ContainsKey(sender) && users.ContainsKey(receiver))
                    {
                        users[sender][0] += 1;
                        users[receiver][1] += 1;                      

                        if (users[sender][0] + users[sender][1] >= capacity)
                        {
                           
                            users.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        if (users[receiver][0] + users[receiver][1] >= capacity)
                        {
                           
                            users.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }
                }
                if (commandType == "Empty")
                {
                    string username = tokens[1];
                    if (username == "All")
                    {
                        users.Clear();
                    }
                    if (users.ContainsKey(username))
                    {                                               
                        users.Remove(username);
                    }
                }
            }
            Console.WriteLine($"Users count: {users.Count}");

            if (users.Count > 0)
            {
                foreach (var user in users.OrderBy(user => user.Key[0]))
                {
                    Console.WriteLine($"{user.Key} - {user.Value[0] + user.Value[1]}");
                }
            }

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace The_Pianist___Associtative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pianists = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputParts = input.Split("|");
                string piece = inputParts[0];
                string composer = inputParts[1];
                string key = inputParts[2];

                pianists.Add(piece, new List<string>());
                pianists[piece].Add(composer);
                pianists[piece].Add(key);
            }


            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandParts = command.Split("|");
                string commandType = commandParts[0];
                if (commandType == "Add")
                {
                    string piece = commandParts[1];
                    string composer = commandParts[2];
                    string key = commandParts[3];
                    if (pianists.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        pianists.Add(piece, new List<string>());
                        pianists[piece].Add(composer);
                        pianists[piece].Add(key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                if (commandType == "Remove")
                {
                    string piece = commandParts[1];
                    if (pianists.ContainsKey(piece))
                    {
                        pianists.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                if (commandType == "ChangeKey")
                {
                    string piece = commandParts[1];
                    string newKey = commandParts[2];
                    if (pianists.ContainsKey(piece))
                    {
                        pianists[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

            }

            foreach (var piece in pianists)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }

    }
}

using System;

namespace Secret_Chat___Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split(":|:");
                string commandType = commandParts[0];
                if (commandType == "Reveal")
                {
                    break;
                }
                if (commandType == "InsertSpace")
                {
                    int index = int.Parse(commandParts[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                if (commandType == "Reverse")
                {
                    string substring = commandParts[1];
                    if (message.Contains(substring))
                    {
                        string cuttedPart = string.Empty;
                        int index = message.IndexOf(substring);
                        message = message.Remove(index,substring.Length);
                        for (int i = substring.Length-1; i >= 0; i--)
                        {
                            cuttedPart += substring[i];
                        }
                        message += cuttedPart;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                if (commandType == "ChangeAll")
                {
                    
                    string substring = commandParts[1];
                    string replacement = commandParts[2];
                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                        Console.WriteLine(message);
                    }
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}

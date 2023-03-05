using System;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            while (true)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split("|");
                string commandType = commandArgs[0];
                if (commandType == "Decode")
                {
                    break;
                }
                if (commandType == "Move")
                {
                    string firstNLetters = string.Empty;
                    int n = int.Parse(commandArgs[1]);
                    for (int i = 0; i < encryptedMessage.Length-1; i++)
                    {                        
                        if (i==n)
                        {
                            break;
                        }
                        firstNLetters += encryptedMessage[i];
                    }
                    encryptedMessage = encryptedMessage.Remove(0, n);
                    encryptedMessage += firstNLetters;
                }
                if (commandType == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];
                    encryptedMessage = encryptedMessage.Insert(index, value);
                }
                if (commandType == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];
                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}

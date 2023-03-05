using System;

namespace Password_Reset___Text_Processing
{
    class Program
    {

        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandArgs = command.Split(" ");

                string commandType = commandArgs[0];
                if (commandType == "TakeOdd")
                {
                    string rawPass = string.Empty;

                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            rawPass += password[i];
                        }

                    }
                    Console.WriteLine(rawPass);
                    password = rawPass;
                }
                if (commandType == "Cut")
                {
                    int index = int.Parse(commandArgs[1]);
                    int length = int.Parse(commandArgs[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                if (commandType == "Substitute")
                {                 

                    if (password.Contains(commandArgs[1]))
                    {
                        string substring = commandArgs[1];
                        string substitute = commandArgs[2];
                        password = password.Replace(substring, substitute);                       
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}

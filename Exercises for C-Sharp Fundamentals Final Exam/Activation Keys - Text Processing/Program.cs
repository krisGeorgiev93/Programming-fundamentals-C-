using System;

namespace Activation_Keys___Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandArgs = command.Split(">>>");

                string commandType = commandArgs[0];
                if (commandType == "Contains")
                {//For the "Contains" command, we simply check if the raw activation key contains
                 //the specified substring and print the appropriate message.


                    string substring = commandArgs[1];
                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                if (commandType == "Flip")
                {//For the "Flip" command, we extract the specified substring from the raw activation key,
                 //convert it to upper or lower case as specified, and replace it in the raw activation key. Then, we print the modified raw activation key.


                    int startIndex = int.Parse(commandArgs[2]);
                    int endIndex = int.Parse(commandArgs[3]);
                    string substring = rawActivationKey.Substring(startIndex, endIndex - startIndex);

                    if (commandArgs[1] == "Upper")
                    {
                        substring = substring.ToUpper();
                    }
                    else
                    {
                        substring = substring.ToLower();
                    }

                    rawActivationKey = rawActivationKey.Substring(0, startIndex) + substring + rawActivationKey.Substring(endIndex);

                    Console.WriteLine(rawActivationKey);
                }
                if (commandType == "Slice")
                {//For the "Slice" command, we extract the specified substring from the
                 //raw activation key and replace it with an empty string. Then, we print the modified raw activation key.



                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    rawActivationKey = rawActivationKey.Substring(0, startIndex) + rawActivationKey.Substring(endIndex);

                    Console.WriteLine(rawActivationKey);
                }


            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}

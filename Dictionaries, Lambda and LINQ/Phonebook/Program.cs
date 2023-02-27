﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (command != "END")
            {
                string[] commandArgs = command.Split(" ");
                string commandType = commandArgs[0];
                string name = commandArgs[1];              

                if (commandType == "A")
                {
                    string phoneNumber = commandArgs[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook[name] = string.Empty;
                    }                   
                    phonebook[name] = phoneNumber;
                }

                if (commandType == "S")
                {                    
                    if (phonebook.ContainsKey(name))
                    {
                       
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                command = Console.ReadLine();
            }

        }
    }
}

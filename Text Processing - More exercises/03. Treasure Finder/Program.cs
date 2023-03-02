﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        string[] initialKey = Console.ReadLine().Split(' ').ToArray();
        string key = string.Join("", initialKey);
        string input = Console.ReadLine();

        while (input != "find")
        {
            while (input.Length > key.Length)
            {
                key += key;
            }
            string newResult = "";
            for (int i = 0; i < input.Length; i++)
            {
                int number = int.Parse(key[i].ToString());
                newResult += (char)(input[i] - number);
            }

            if (newResult.Contains('&') && newResult.Contains('>') && newResult.Contains('<'))
            {
                //hidden&gold&at<10N70W>
                int firstGoldIndex = newResult.IndexOf('&');
                int secondGoldIndex = newResult.IndexOf('&', firstGoldIndex + 1);
                int firstCoordIndex = newResult.IndexOf('<');
                int secondCoordIndex = newResult.IndexOf('>');
                string material = newResult.Substring(firstGoldIndex + 1, secondGoldIndex - firstGoldIndex - 1);
                string coordinates = newResult.Substring(firstCoordIndex + 1, secondCoordIndex - firstCoordIndex - 1);
                Console.WriteLine($"Found {material} at {coordinates}");
            }
            input = Console.ReadLine();
        }
    }
}
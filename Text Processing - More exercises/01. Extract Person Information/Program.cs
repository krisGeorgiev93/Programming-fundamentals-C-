﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            int indexOfA = input.IndexOf('@');
            int indexOfB = input.IndexOf('|');
            int indexOfC = input.IndexOf('#');
            int indexOfD = input.IndexOf('*');

            string name = input.Substring(indexOfA + 1, indexOfB - indexOfA - 1);
            int age = int.Parse(input.Substring(indexOfC + 1, indexOfD - indexOfC - 1));
            Console.WriteLine($"{name} is {age} years old.");
        }
    }
}
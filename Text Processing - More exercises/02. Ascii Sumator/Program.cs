﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        int first = char.Parse(Console.ReadLine());
        int second = char.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        int sum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] > first && text[i] < second)
            {
                sum += text[i];
            }
        }
        Console.WriteLine(sum);
    }
}
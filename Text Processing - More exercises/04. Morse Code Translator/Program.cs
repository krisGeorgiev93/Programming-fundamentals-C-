﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        foreach (var word in input)
        {

            string letter = word.ToString();
            if (letter == ".-")
            {
                Console.Write("A");
            }
            else if (letter == "-...")
            {
                Console.Write("B");
            }
            else if (letter == "-.-.")
            {
                Console.Write("C");
            }
            else if (letter == "-..")
            {
                Console.Write("D");
            }
            else if (letter == ".")
            {
                Console.Write("E");
            }
            else if (letter == "..-.")
            {
                Console.Write("F");
            }
            else if (letter == "--.")
            {
                Console.Write("G");
            }
            else if (letter == "....")
            {
                Console.Write("H");
            }
            else if (letter == "..")
            {
                Console.Write("I");
            }
            else if (letter == ".---")
            {
                Console.Write("J");
            }
            else if (letter == "-.-")
            {
                Console.Write("K");
            }
            else if (letter == ".-..")
            {
                Console.Write("L");
            }
            else if (letter == "--")
            {
                Console.Write("M");
            }
            else if (letter == "-.")
            {
                Console.Write("N");
            }
            else if (letter == "---")
            {
                Console.Write("O");
            }
            else if (letter == ".--.")
            {
                Console.Write("P");
            }
            else if (letter == "--.-")
            {
                Console.Write("Q");
            }
            else if (letter == ".-.")
            {
                Console.Write("R");
            }
            else if (letter == "...")
            {
                Console.Write("S");
            }
            else if (letter == "-")
            {
                Console.Write("T");
            }
            else if (letter == "..-")
            {
                Console.Write("U");
            }
            else if (letter == "...-")
            {
                Console.Write("V");
            }
            else if (letter == ".--")
            {
                Console.Write("W");
            }
            else if (letter == "-..-")
            {
                Console.Write("X");
            }
            else if (letter == "-.--")
            {
                Console.Write("Y");
            }
            else if (letter == "--..")
            {
                Console.Write("Z");
            }
            else if (letter == "|")
            {
                Console.Write(" ");
            }
        }
    }
}
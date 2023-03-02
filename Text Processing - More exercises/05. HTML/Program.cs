﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        string title = Console.ReadLine();
        string content = Console.ReadLine();
        string comment = Console.ReadLine();

        Console.WriteLine("<h1>");
        Console.WriteLine(title);
        Console.WriteLine("</h1>");

        Console.WriteLine("<article>");
        Console.WriteLine(content);
        Console.WriteLine("</article>");

        while (comment != "end of comments")
        {
            Console.WriteLine($"<div>");
            Console.WriteLine($"    {comment}");
            Console.WriteLine($"</div>");
            comment = Console.ReadLine();
        }
    }
}
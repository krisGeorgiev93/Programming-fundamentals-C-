using System;
using System.Collections.Generic;
public class StudentsExample
{
    public static void Main()
    {
        var studentMarks = new Dictionary<string, double>();
        studentMarks["Pesho"] = 3.00;
        studentMarks["Gosho"] = 4.50;
        studentMarks["Nakov"] = 5.50;
        studentMarks["Vesko"] = 3.50;
        studentMarks["Tsanev"] = 4.00;
        studentMarks["Nerdy"] = 6.00;

        double tsanevMark = studentMarks["Tsanev"];

        Console.WriteLine("Tsanev's mark: {0:0.00}", tsanevMark);
        studentMarks.Remove("Tsanev");
        Console.WriteLine("Tsanev's mark removed.");
        Console.WriteLine("Is Tsanev in the dictionary: {0}", studentMarks.ContainsKey("Tsanev") ? "Yes!" : "No!");
        Console.WriteLine("Nerdy's mark is {0:0.00}.", studentMarks["Nerdy"]);
        studentMarks["Nerdy"] = 3.25;
        Console.WriteLine(
        "But we all know he deserves no more than {0:0.00}.", studentMarks["Nerdy"]);
        double mishosMark;
        bool findMisho = studentMarks.TryGetValue("Misho", out mishosMark);
        Console.WriteLine(
        "Is Misho's mark in the dictionary? {0}", findMisho ? "Yes!" : "No!");
        studentMarks["Misho"] = 6.00;
        findMisho = studentMarks.TryGetValue("Misho", out mishosMark);
        Console.WriteLine("Let's try again: {0}. Misho's mark is {1}", findMisho ? "Yes!" : "No!", mishosMark);
        Console.WriteLine("Students and marks:");

        foreach (var studentMark in studentMarks)
        {
            Console.WriteLine("{0} has {1:0.00}", studentMark.Key, studentMark.Value);
        }

        Console.WriteLine("There are {0} students in the dictionary", studentMarks.Count);
        studentMarks.Clear();
        Console.WriteLine("Students dictionary cleared.");
        Console.WriteLine("Is dictionary empty: {0}", studentMarks.Count == 0);
    }
}
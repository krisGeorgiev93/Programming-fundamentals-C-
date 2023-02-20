using System;
using System.Collections.Generic;
public class WordsCountingWithSOrtedDictionary
{
    private static readonly string Text =
    "She uchish li she bachkash li? Be kvo she bachkash " +
    "be? Tui vashto uchene li e? Ia po-hubavo opitai da " +
    "BACHKASH da se uchish malko! Uchish ne uchish trqbva " +
    "da bachkash!";
    public static void Main()
    {
        var wordOccurrences = GetWordOccurrences(Text);
        PrintWordOccurrenceCount(wordOccurrences);
    }
    static IDictionary<string, int> GetWordOccurrences(string text)
    {
        string[] tokens = text.Split(' ', '.', ',', '-', '?', '!');
        var words = new SortedDictionary<string, int>();
        foreach (string word in tokens)
        {
            if (!string.IsNullOrEmpty(word.Trim()))
            {
                int count = 0;
                words.TryGetValue(word, out count);
                words[word] = count + 1;
            }
        }
        return words;
    }
    static void PrintWordOccurrenceCount(
    IDictionary<string, int> wordOccurrence)
    {
        foreach (var wordEntry in wordOccurrence)
        {
            Console.WriteLine("Word '{0}' occurs {1} time(s) in the text", wordEntry.Key, wordEntry.Value);
        }
    }
}
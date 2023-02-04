using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var currentWord in bannedWords)
            {
                text = text.Replace(currentWord, new string ('*', currentWord.Length));
            }
            Console.WriteLine(text);
        }
    }
}

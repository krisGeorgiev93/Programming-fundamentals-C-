using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelsCount = GetVowelsCount(text);
            Console.WriteLine(vowelsCount);
        }

         static int GetVowelsCount(string text)
        {
            int vowelsCount = 0;
            char[] vowels = new char[] { 'a', 'o', 'e', 'i', 'u', 'y' };
            foreach (char letters in text.ToLower())
            {
                if (vowels.Contains(letters))
                {
                    vowelsCount++;
                }
            }
            return (vowelsCount);
        }
    }
}

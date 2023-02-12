using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalRepeats = int.Parse(Console.ReadLine());

            string result = RepeatString(input, totalRepeats);
            Console.WriteLine(result);
        }

        private static string RepeatString(string input, int totalRepeats)
        {
            string result = "";
            for (int i = 1; i <= totalRepeats; i++)
            {
                result += input;
            }
            return result.ToString();
        }
    }
}

using System;
using System.Linq;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] words = Console.ReadLine().Split();
            string result = string.Empty;

            foreach (var word in words)
            {
                int repeatTimes = word.Length;
                for (int i = 0; i < repeatTimes; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}

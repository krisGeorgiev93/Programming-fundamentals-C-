using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum += (number % 10); // returns the last digit of the "number"
                number = number / 10; // deletes the last digit of "number"

            }
            while (number > 0);

            Console.WriteLine(sum);
        }
    }
}

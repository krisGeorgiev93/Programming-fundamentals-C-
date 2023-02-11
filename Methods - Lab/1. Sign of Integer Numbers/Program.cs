using System;

namespace _1._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            theCheckedNumber(inputNumber);
        }

        private static void theCheckedNumber(int inputNumber)
        {
            if (inputNumber > 0)
            {
                Console.WriteLine($"The number {inputNumber} is positive. ");
            }
            else if (inputNumber < 0)
            {
                Console.WriteLine($"The number {inputNumber} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {inputNumber} is zero. ");

            }
        }
    }
}

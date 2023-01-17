using System;

namespace _4._Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = number1; i <= number2; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine(); // nov red
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            
            int theSmallesttNumber = GetTheSmallestNumber(number1, number2, number3);
            Console.WriteLine(theSmallesttNumber);
        }

       static int GetTheSmallestNumber(int number1, int number2, int number3)
        {
            int minNum = int.MaxValue;
            if (number1 < number2 && number1 < number3)
            {
                minNum = number1;
            }
            else if (number2 < number1 && number2 < number3)
            {
                minNum = number2;
            }
            else
            {
                minNum = number3;
            }
            return minNum;
        }
    }
}

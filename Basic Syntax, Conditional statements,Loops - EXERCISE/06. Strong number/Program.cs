using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Modular divison by 10 --> return last digit
            //integer division by 10 --> removes last digit
            int numCopy = n; // pravim negovo kopie koeto e syshtotot kato n
            int factorialSum = 0; // tuk shte pazim sumata ot vsichki chisla 
            while (numCopy > 0)
            {
                int lastDigit = numCopy % 10; // Take last digit
                numCopy /= 10; // remove last digit
                // Calculate factorial of last digit
                int factorial = 1; // Start from 1 ( 1*n = n) (0*n=0 wrong)
                for (int i = 2; i <= lastDigit; i++) // sled tova 2 do poslednoto chislo 
                {
                    factorial *= i; // i umnojavame factoriala sys i vseki pyt
                }
                factorialSum += factorial;
            }

            if (factorialSum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

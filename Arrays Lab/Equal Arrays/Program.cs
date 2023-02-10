using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split().ToArray();
            string[] array2 = Console.ReadLine().Split().ToArray();

            int sum = 0;           

            for (int i = 0; i < array2.Length; i++)
            {                
                    if (array1[i] == array2[i])
                    {
                    sum += int.Parse(array1[i]);
                    }
                    else
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        return;
                    }                
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}

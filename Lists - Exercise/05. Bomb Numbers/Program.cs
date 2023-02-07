using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine() 
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> line = Console.ReadLine() 
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int bomb = line[0];
            int power = line[1]; 

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb) 
                {
                    int lowerRange = i - power; 
                    int count = 1 + (power * 2);

                    if (lowerRange < 0)
                    {
                        lowerRange = 0;
                        count--;
                    }

                    if (i >= numbers.Count - 1 || (count + lowerRange) - 1 >= numbers.Count)
                    {
                        count = numbers.Count - lowerRange;
                    }

                    numbers.RemoveRange(lowerRange, count);

                    i = -1;
                    // important to set back i -= 1, in order to not miss out on a given position
                    // see in Debug  how code behaves
                    //numbers.RemoveAt(i);
                    //for (int k = i; k < i + power; k++)
                    //{
                    //    if (k >= numbers.Count)
                    //    {
                    //        break;
                    //    }
                    //    numbers.RemoveAt(k);
                    //}

                    //for (int j = i - power; j < i; j++)
                    //{
                    //    if (j < 0)
                    //    {
                    //        continue;
                    //    }
                    //    numbers.RemoveAt(j);
                    //    //numbers.RemoveAt(j--);
                    //    //i--;
                    //}

                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}

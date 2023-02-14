using System;
using System.Collections.Generic;
using System.Linq;
namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstColletion = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondCollection = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> result = new List<int>();

            // 1 2 3 4
            // 1 2 3

            int n = Math.Min(firstColletion.Count, secondCollection.Count); // vzemame dyljinata na po malkata kolekciq
                                                                           // i pravim for cikyl do dyljinata na po malkata ( 1 2 3 )
            for (int i = 0; i < n; i++)
            {
                result.Add(firstColletion[i]);
                result.Add(secondCollection[i]);
            }

            if (firstColletion.Count > secondCollection.Count)    // tuk dobavqme ostanalite chisla ot po golqmata kolekciq
            {
                for (int i = n; i < firstColletion.Count; i++)
                {
                    result.Add(firstColletion[i]);
                }
            }
            else if (secondCollection.Count > firstColletion.Count)
            {
                for (int i = n; i < secondCollection.Count; i++)
                {
                    result.Add(secondCollection[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

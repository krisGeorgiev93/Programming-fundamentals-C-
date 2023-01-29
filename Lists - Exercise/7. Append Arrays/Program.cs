using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        { //1ВИ ВАРИАНТ !
          // List<string> listOfArrays = Console.ReadLine()
          //     .Split('|')
          //     .ToList();
          // for (int i = listOfArrays.Count - 1; i >= 0; i--)
          // {
          //     string[] arrays = listOfArrays[i].Split().ToArray();
          //
          //     for (int k = 0; k <= arrays.Length - 1; k++)
          //     {
          //         Console.Write($"{arrays[k]} ");
          //     }
          // }


          // 2РИ ВАРИАНТ (по добър)
          //Първо трябва да прочетеш инпута и да гo Split-неш по ('|'), след което за да стане последния първи (Order the arrays from the last to the first)
          // просто го Reverse-ваш, може и още при четенето и ще се получи нещо такова:
            List<string> numbersAsStrings = Console.ReadLine()
                                .Split('|')
                                .Reverse() // така обръщаме листа
                                .ToList();
            //След това (вече са подредени отзад-напред), трябва да сплитнеш всеки стринг, по отделно и да ги добавиш в един
            //List<int> или да събереш Lista-a от string-ове в 1 стринг и него да Split-неш, по един или повече спейсове и да го налееш в един List<int>.
            List<int> numbers = new List<int>();
            foreach (var str in numbersAsStrings)
            {
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList());               
            }
            Console.WriteLine(string.Join(" ", numbers));
            //Забележи, че Split-вам променливата "Str", която е индивидуален string от List-а със string-ове!
            //И по този начин числата си се редят отляво - надясно.


        }
    }
}

using System;
using System.Linq;

namespace _2___Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            while (true)
            {
                string[] commandArgs = command.Split();
                string operation = commandArgs[0];

                if (command == "end")
                {
                    Console.WriteLine(string.Join(", ",array));
                    break;
                }
                if (operation == "swap") 
                {
                    int index1 = int.Parse(commandArgs[1]);
                    int index2 = int.Parse(commandArgs[2]);

                    int valueIndex1 = array[index1]; 
                    int valueIndex2 = array[index2];

                    array[index1] = valueIndex2;
                    array[index2] = valueIndex1;
                }
                if (operation == "multiply") 
                {
                    int index1 = int.Parse(commandArgs[1]);
                    int index2 = int.Parse(commandArgs[2]);
                    int valueIndex1 = array[index1]; 
                    int valueIndex2 = array[index2];
                    int multiplyedValue = valueIndex1 * valueIndex2;

                    array[index1] = multiplyedValue; // РЕЗУЛТАТА ОТИВА В ПЪРВИ ИНДЕКС КАКТО Е ПО УСЛОВИЕ
                }
                if (operation == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1; // ОТ ВСЕКИ ЕЛЕМЕНТ В МАСИВА ВАДИМ 1ЦА
                    }
                }
                command = Console.ReadLine();
            }
            
        }
    }
}

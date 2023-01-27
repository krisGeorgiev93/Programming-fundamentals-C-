using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Shoot_for_the_Win_03_Mid_Exam_Retake
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string index = Console.ReadLine();
            int count = 0;

            while (index != "End")
            {
                int newIndex = int.Parse(index);

                //if (newIndex > targets.Count - 1)
                if (newIndex < 0 || newIndex >= targets.Length || targets[newIndex] == -1)
                {
                    index = Console.ReadLine();
                    continue;
                }

                int oldValue = targets[newIndex];
                //int oldValue = targets[newIndex];
                //targets.RemoveAt(newIndex);
                //targets.Insert(newIndex, -1);

                targets[newIndex] = -1;
                count++;
                for (int i = 0; i <= targets.Length - 1; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }

                    if (oldValue < targets[i])
                    {

                        int newValue = targets[i] - oldValue;
                        targets[i] = newValue;


                        //targets.RemoveAt(i);
                        //targets.Insert(i, newValue);
                    }
                    else if (oldValue >= targets[i] && targets[i] != -1)
                    {
                        int newValue = oldValue + targets[i];
                        targets[i] = newValue;

                        //targets.RemoveAt(i);
                        //targets.Insert(i, newValue);
                    }

                }
                index = Console.ReadLine();
            }

            Console.Write($"Shot targets: {count} -> {string.Join(" ", targets)}");
        }
    }
}
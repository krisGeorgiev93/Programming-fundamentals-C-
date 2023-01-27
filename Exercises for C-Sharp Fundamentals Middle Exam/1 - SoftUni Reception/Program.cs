using System;

namespace _1___SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeHelpPerHour = int.Parse(Console.ReadLine());
            int secondEmployeeHelpPerHour = int.Parse(Console.ReadLine());
            int thirdEmployeeHelpPerHour = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int hoursCounter = 0;
            int answeredQuestions = 0;

            int totalAnswersForHour = firstEmployeeHelpPerHour + secondEmployeeHelpPerHour + thirdEmployeeHelpPerHour;

            while (answeredQuestions < studentsCount)
            {

                int oneHoure = 1 * totalAnswersForHour;
                answeredQuestions += oneHoure;
                hoursCounter++;
                    if (hoursCounter % 4 == 0)
                    {
                        hoursCounter++;
                    }               

            }
            Console.WriteLine($"Time needed: {hoursCounter}h.");
        }
    }
}

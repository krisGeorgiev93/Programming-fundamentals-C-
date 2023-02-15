using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string> >courses = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine())!= "end")
            {
                string[] commandArgs = command.Split(" : ");
                string courseName = commandArgs[0];
                string studentName = commandArgs[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName,new List<string>());
                }
                courses[courseName].Add(studentName);
            }


            foreach (var kvp in courses)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
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
            Dictionary<string, double[]> studentsAndGrades = new Dictionary<string, double[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsAndGrades.ContainsKey(studentName))
                {
                    studentsAndGrades.Add(studentName, new double[2]);
                }
                studentsAndGrades[studentName][0] += grade; // Add grade
                studentsAndGrades[studentName][1]++; // Count grades              
            }

            foreach (var student in studentsAndGrades)
            {
                double averageGrade = student.Value[0] / student.Value[1];
                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }
        }
    }
}
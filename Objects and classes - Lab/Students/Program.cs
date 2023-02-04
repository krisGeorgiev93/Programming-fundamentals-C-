using System;
using System.Collections.Generic;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] personInfo = input.Split();
                string firstName = personInfo[0];
                string lastName = personInfo[1];
                int age = int.Parse(personInfo[2]); 
                string town = personInfo[3];
                
                Student student = new Student(firstName, lastName, age, town);
                students.Add(student); // Add every student into collection
                input = Console.ReadLine();
            }
            string desiredTown = Console.ReadLine(); 

            foreach (var currentStudent in students)
            {
                if (currentStudent.Town == desiredTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }

        }
      


        public class Student
        {
            //Create the constructor
            public Student(string firstName, string lastName, int age, string town)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Town = town;
            }
            // Create properties
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Town { get; set; }
        }
    }
}

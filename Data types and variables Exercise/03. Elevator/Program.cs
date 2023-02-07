using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int totalCourses = (int)Math.Ceiling((double)people / capacity);
            Console.WriteLine(totalCourses);

        }
    }
}

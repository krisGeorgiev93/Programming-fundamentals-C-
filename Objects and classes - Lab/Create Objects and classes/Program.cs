using System;

namespace Create_Objects_and_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //{
            //    Name = "Kiko",
            //    Age = 26
            //};
            student.Name = "Kiko";
            student.Age = 26;


            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
        }
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}

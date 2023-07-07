using System;

namespace InsertStudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student information:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Student Number: ");
            string studentNumberString = Console.ReadLine();
            int studentNumber = int.Parse(studentNumberString);

            Console.Write("Grade: ");
            string gradeString = Console.ReadLine();
            int grade = int.Parse(gradeString);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{name}\n{studentNumber}\n{grade}%");
        }
    }
}

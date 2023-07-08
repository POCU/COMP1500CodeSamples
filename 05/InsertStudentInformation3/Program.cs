using System;

namespace InsertStudentInformation3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student information:");
            string[] names = new string[3];
            string[] studentNumbers = new string[3];
            int[] grades = new int[3];

            Console.WriteLine("Fill out information for student 1.");

            Console.Write("Name: ");
            names[0] = Console.ReadLine();

            Console.Write("Student Number: ");
            studentNumbers[0] = Console.ReadLine();

            Console.Write("Grade: ");
            string gradeString = Console.ReadLine();
            grades[0] = int.Parse(gradeString);

            Console.WriteLine();
            Console.WriteLine("Fill out information for student 2.");

            Console.Write("Name: ");
            names[1] = Console.ReadLine();

            Console.Write("Student Number: ");
            studentNumbers[1] = Console.ReadLine();

            Console.Write("Grade: ");
            gradeString = Console.ReadLine();
            grades[1] = int.Parse(gradeString);

            Console.WriteLine();
            Console.WriteLine("Fill out information for student 3.");

            Console.Write("Name: ");
            names[2] = Console.ReadLine();

            Console.Write("Student Number: ");
            studentNumbers[2] = Console.ReadLine();

            Console.Write("Grade: ");
            gradeString = Console.ReadLine();
            grades[2] = int.Parse(gradeString);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1   {0,-20}   {1,-20}   {2}%", names[0], studentNumbers[0], grades[0]);
            Console.WriteLine("2   {0,-20}   {1,-20}   {2}%", names[1], studentNumbers[1], grades[1]);
            Console.WriteLine("3   {0,-20}   {1,-20}   {2}%", names[2], studentNumbers[2], grades[2]);
        }
    }
}

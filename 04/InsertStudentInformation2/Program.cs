using System;

namespace InsertStudentInformation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student grade:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Grade: ");
            string gradeString = Console.ReadLine();
            int grade = int.Parse(gradeString);

            if (grade >= 90)
            {
                Console.Write("Excellent! You are an A student!");
            }
            else if (grade >= 80)
            {
                Console.Write("Good! You are above average!");
            }
            else if (grade >= 70)
            {
                Console.Write("Meh... You are doing alright...");
            }
            else if (grade >= 50)
                Console.Write("Are you even trying? You can do better than that!"); // DON'T DO THIS!!! ALWAYS USE { }

            else
            {
                Console.Write("You have no talent... Maybe you should do something else?");
            }
        }
    }
}

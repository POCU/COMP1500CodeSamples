using System;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseCode courseCode1 = new CourseCode(ESubject.COMP, 3200);

            Console.WriteLine($"{courseCode1.Subject} {courseCode1.Number}");

            CourseCode courseCode2 = CourseCode.Parse("MATH1100");
            Console.WriteLine($"{courseCode2.Subject} {courseCode2.Number}");

            //CourseCode.Parse("What is this madness!");

            CourseCode courseCode3;
            bool bParsed = CourseCode.TryParse("What is this madness!", out courseCode3);

            Console.WriteLine($"Parsed: {bParsed}");

            CourseCode courseCode4;
            bParsed = CourseCode.TryParse("MATH1100", out courseCode4);

            Console.WriteLine($"Parsed: {bParsed}");
            Console.WriteLine($"{courseCode4.Subject} {courseCode4.Number}");
        }
    }
}

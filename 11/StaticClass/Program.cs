using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseCode courseCode1 = new CourseCode(ESubject.COMP, 3200);

            Console.WriteLine($"{courseCode1.Subject} {courseCode1.Number}");

            //courseCode.Subject = ESubject.MATH;

            CourseCode.Parse("MATH1100");

            //CourseCode.Parse("What is this madness!");

            CourseCode courseCode2;
            bool bParsed = CourseCode.TryParse("What is this madness!", out courseCode2);

            Console.WriteLine($"Parsed: {bParsed}");

            CourseCode courseCode3;
            bParsed = CourseCode.TryParse("MATH1100", out courseCode3);

            Console.WriteLine($"Parsed: {bParsed}");
            Console.WriteLine($"{courseCode1.Subject} {courseCode1.Number}");

            double centimeters = UnitConverter.GetCentimetersFromInches(1.24);
            double feet = UnitConverter.GetFeetFromInches(12);
            double inches = UnitConverter.GetInchesFromCentimeters(5.7);
            double meters = UnitConverter.GetMetersFromCentimeters(254.92);

            Console.WriteLine(centimeters);
            Console.WriteLine(feet);
            Console.WriteLine(inches);
            Console.WriteLine(meters);
        }
    }
}

using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 48;
            int num2 = 65;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + (num1 + num2));
            Console.WriteLine(string.Format("The sum of {0} and {1} is {2}", num1, num2, num1 + num2));
            Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");

            Console.WriteLine($"\x48\x65\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21");
            Console.WriteLine(@"\x48\x65\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21");

            Console.WriteLine($@"\x{num1}\x{num2}\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21");
        }
    }
}

using System;

namespace DefaultParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar("POCU");
            Bar("POCU", "COMP1500");
            Bar("POCU", "COMP1500", "Intro to programming!");
        }

        static void Bar(string s, string s2 = "", string s3 = "")
        {
            Console.WriteLine($"{s}, {s2}, {s3}");
        }
    }
}

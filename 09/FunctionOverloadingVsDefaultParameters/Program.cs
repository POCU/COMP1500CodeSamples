using System;

namespace FunctionOverloadingVsDefaultParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo();
            Foo(10);
            Foo("POCU");
            Foo("POCU", "COMP1500", "Intro to programming!");

            Console.WriteLine("--------------------------------------");

            Bar("POCU");
            Bar("POCU", "COMP1500");
            Bar("POCU", "COMP1500", "Intro to programming!");
        }

        static void Foo()
        {
            Console.WriteLine("Foo with no arguments.");
        }

        static void Foo(int x)
        {
            Console.WriteLine($"Foo with {typeof(int).Name}: {x} as an argument.");
        }

        //static int Foo(int x)
        //{
        //    return x + 1;
        //}

        static void Foo(string s)
        {
            Console.WriteLine($"Foo with {typeof(string).Name}: {s} as an argument.");
        }

        static void Foo(string s1, string s2, string s3)
        {
            Console.WriteLine($"Foo with {typeof(string).Name}: {s1}, {typeof(string).Name}: {s2} and {typeof(string).Name}: {s3} as an argument.");
        }

        //static void Foo(string s, string s2 = "", string s3 = "")
        //{
        //    Console.WriteLine($"Foo with {typeof(string).Name}: {s}, {typeof(string).Name}: {s2} and {typeof(string).Name}: {s3} as an argument.");
        //}

        static void Bar(string s, string s2 = "", string s3 = "")
        {
            Console.WriteLine($"Bar with {typeof(string).Name}: {s}, {typeof(string).Name}: {s2} and {typeof(string).Name}: {s3} as an argument.");
        }
    }
}

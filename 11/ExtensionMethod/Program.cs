using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            const string HELLO_WORLD = "Hello World!";

            string reversed = HELLO_WORLD.Reverse();

            Console.WriteLine(reversed);

            string reversed2 = HELLO_WORLD.Reverse(2, 8);

            Console.WriteLine(reversed2);
        }
    }
}

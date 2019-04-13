using System;

namespace CallByValueAndCallByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            IncrementByValue(num1, 2, 5);

            Console.WriteLine($"num1 after IncrementByValue(): {num1}");

            IncrementByReference(ref num1, 2, 5);

            Console.WriteLine($"num1 after IncrementByReference(): {num1}");
        }

        static void IncrementByValue(int num, int increment, int incrementCount)
        {
            for (int i = 0; i < incrementCount; i++)
            {
                num += increment;
            }
        }

        static void IncrementByReference(ref int num, int increment, int incrementcount)
        {
            for (int i = 0; i < incrementCount; i++)
            {
                num += increment;
            }
        }
    }
}

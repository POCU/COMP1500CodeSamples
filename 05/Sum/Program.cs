using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;

            Console.WriteLine($"Sum of 1 - {MAX}");

            int sum = 0;
            for (int i = 0; i < MAX; i++)
            {
                sum += (i + 1);
            }

            Console.WriteLine(sum);
        }
    }
}

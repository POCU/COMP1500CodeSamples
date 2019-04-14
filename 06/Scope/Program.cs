using System;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            const int THRESHOLD = 10;

            int[] numbers = new int[] { 1, -3, 4, -10, 4, 2, 9, 15 };
            int average = GetAverage(numbers);

            if (average > THRESHOLD)
            {
                //int average = 0; // Compile error!
                string message = "Message in the if statement!";
                Console.WriteLine(message);
            }
            else
            {
                //int average = 0; // Compile error!
                string message = "Message in the else statement!";
                Console.WriteLine(message);
            }
        }

        static int GetAverage(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}

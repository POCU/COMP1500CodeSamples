using System;
using System.Diagnostics;

namespace InputValidationUsingAssert
{
    class Program
    {
        static void Main(string[] args)
        {
            double quotient1 = Divide(2, 1);
            double quotient2 = Divide(3, 6);

            // double quotient3 = Divide(5, 0);

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            PrintRange(0, 10, numbers);
            PrintRange(3, 7, numbers);
            PrintRange(8, 10, numbers);

            //PrintRange(-1, 3, numbers);
            //PrintRange(2, -10, numbers);

        }

        static double Divide(int x, int y)
        {
            Debug.Assert(y != 0, "y cannot be 0");

            double quotient = x / (double)y;
            return quotient;
        }

        static void PrintRange(int start, int end, int[] numbers)
        {
            Debug.Assert(start >= 0, "start cannot be less than 0");
            Debug.Assert(end >= 0, "end cannot be less than 0");

            Console.Write("[");

            for (int i = start; i < end; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }

            if (numbers.Length > 0)
            {
                Console.Write(numbers[numbers.Length - 1]);
            }

            Console.WriteLine("]");
        }
    }
}

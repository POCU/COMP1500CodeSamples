using System;

namespace FunctionVsRegion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = new int[] { 2, -4, 2, 5, 7, -9, 10, 11, -8, 4 };

            #region PRINT_ARRAY
            Console.Write("[");

            for (int i = 0; i < numbers1.Length - 1; i++)
            {
                Console.Write($"{numbers1[i]}, ");
            }

            if (numbers1.Length > 0)
            {
                Console.Write(numbers1[numbers1.Length - 1]);
            }

            Console.WriteLine("]");
            #endregion

            Console.WriteLine("-------------------------------");

            PrintArray(numbers1);

        }

        static void PrintArray(int[] numbers)
        {
            Console.Write("[");

            for (int i = 0; i < numbers.Length - 1; i++)
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

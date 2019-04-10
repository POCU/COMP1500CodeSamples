using System;

namespace AddTwo2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ROW_COUNT = 4;
            const int COLUMN_COUNT = 5;

            int[,] array1 = new int[ROW_COUNT, COLUMN_COUNT]
            {
                { 2, 3, 4, 10, 5 },
                { 1, 11, -4, 4, 6 },
                { -11, -4, 6, -3, -3 },
                { 7, 17, 2, -4, 2 }
            };

            int[,] array2 = new int[ROW_COUNT, COLUMN_COUNT]
            {
                { -2, 7, 10, -10, 1 },
                { 2, 7, -6, -13, 6 },
                { 10, 6, -6, 3, 1 },
                { 7, 8, 7, -9, 1 }
            };

            int[,] sumArray = new int[ROW_COUNT, COLUMN_COUNT];

            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COLUMN_COUNT; j++)
                {
                    sumArray[i, j] = array1[i, j] + array2[i, j];
                }
            }

            Console.WriteLine("---Let's print this!---");

            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COLUMN_COUNT; j++)
                {
                    Console.Write("{0,10} ", sumArray[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}

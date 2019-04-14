using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 7;

            int sum1 = x + y;
            int sum2 = Add(x, y);

            Console.WriteLine($"x + y = {sum1}");
            Console.WriteLine($"Add(x, y) = {sum2}");

            int difference1 = x - y;
            int difference2 = Subtract(x, y);

            Console.WriteLine($"x - y = {difference1}");
            Console.WriteLine($"Subtract(x, y) = {difference2}");

            int product1 = x * y;
            int product2 = Multiply(x, y);

            Console.WriteLine($"x * y = {product1}");
            Console.WriteLine($"Multiply(x, y) = {product2}");

            int resultOfA = A(x, y);

            Console.WriteLine($"A(x, y) = {resultOfA}");
        }

        static int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        static int Subtract(int x, int y)
        {
            int difference = x - y;
            return difference;
        }

        static int Multiply(int x, int y)
        {
            int product = x * y;
            return product;
        }

        static int A(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }

            int product = 1;
            for (int i = 0; i < y; i++)
            {
                product *= x;
            }

            return product;
        }
    }
}

using System;

namespace OrderOfExpressionEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 15;
            int num3 = 2;

            int max1 = num1;
            if (num2 > max1)
            {
                max1 = num2;
            }

            if (num3 > max1)
            {
                max1 = num3;
            }

            Console.WriteLine($"max1: {max1}");

            int max2 = num1;
            max2 = num2 > max2 ? num2 : max2;
            max2 = num3 > max2 ? num3 : max2;

            Console.WriteLine($"max2: {max2}");

            int result1 = num1 * num2 + num2 + num2 - num3 * num1;
            Console.WriteLine($"result1: {result1}");

            int result2 = num1 * num2 + (num2 + num2 - num3) * num1;
            Console.WriteLine($"result2: {result2}");

            int result3 = num1 / (num2 + num1) + num1++;
            Console.WriteLine($"result3: {result3}");

            int result4 = num3 >= num1 ? num1 : num3 + num1 * num2;
            Console.WriteLine($"result4: {result4}");

            int result5 = num3 >= num1 ? num1 : (num3 + num1 * num2);
            Console.WriteLine($"result5: {result5}");
        }
    }
}

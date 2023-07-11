using System;

namespace LogicalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 1;
            int num3 = 4;

            bool bExpression1 = !(num1 == num2 && num1 != num3);
            bool bExpression2 = num1 != num2 || num1 == num3;

            Console.WriteLine($"expression1: {bExpression1}");
            Console.WriteLine($"expression2: {bExpression2}");

            bool bExpression3 = num1 > num2 || num1 == num3 || ++num1 > num2;
            Console.WriteLine($"expression3: {bExpression3}");

            bool bExpression4 = num3 >= num2 || num1-- == num2;
            Console.WriteLine($"expression4: {bExpression4}");

            bool bExpression5 = num3 == num1 && --num2 > num1;
            Console.WriteLine($"expression5: {bExpression5}");
        }
    }
}

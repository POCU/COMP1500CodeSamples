using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 11;

            int result1 = num1 + num2;
            int result2 = num1 - num2;

            Console.WriteLine("result1: " + result1);
            Console.WriteLine("result2: " + result2);

            uint result3 = (uint)num1 - (uint)num2;

            Console.WriteLine("result3: " + result3);

            int num3 = int.MaxValue;
            int result4 = num3 + 1;

            Console.WriteLine("result4: " + result4);

            float num4 = 2.3f;

            float result5 = num1 + num4;
            float result6 = num4 - num1;

            Console.WriteLine("result5: " + result5);
            Console.WriteLine("result6: " + result6);

            float result7 = num1 * num4;

            Console.WriteLine("result7: " + result7);

            int result8 = num2 / num1;
            float result9 = num2 / (float)num1;

            Console.WriteLine("result8: " + result8);
            Console.WriteLine("result9: " + result9);

            int result10 = num1 % num2;
            int result11 = num2 % num1;

            Console.WriteLine("result10: " + result10);
            Console.WriteLine("result11: " + result11);

            int result12 = -num1 % num2;
            int result13 = num1 % -num2;

            Console.WriteLine("result12: " + result12);
            Console.WriteLine("result13: " + result13);

            float num5 = 123.452f;
            int num6 = 1000;

            float result14 = num5 % num1;
            float result15 = num6 % num5;

            Console.WriteLine("result14: " + result14);
            Console.WriteLine("result15: " + result15);
        }
    }
}

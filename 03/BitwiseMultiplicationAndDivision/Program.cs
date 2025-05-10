using System;

namespace BitwiseMultiplicationAndDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;

            int result1 = num1 << 1;

            Console.WriteLine("result1: " + result1);

            int result2 = result1 << 2;

            Console.WriteLine("result2: " + result2);

            int result3 = result2 >> 3;

            Console.WriteLine("result3: " + result3);

            //int result4 = result3 << 2.5f;
            //int result5 = 2.1f << 2.5f;
        }
    }
}

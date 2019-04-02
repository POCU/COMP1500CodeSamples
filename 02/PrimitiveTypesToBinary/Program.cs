using System;

namespace PrimitiveTypesToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byte1 = byte.MaxValue;
            byte byte2 = byte.MinValue;

            int int1 = int.MaxValue;
            int int2 = int.MinValue;

            long long1 = long.MinValue;
            long long2 = long.MaxValue;

            char char1 = 'x';
            char char2 = '$';

            Console.WriteLine(byte1 + " -> " + Convert.ToString(byte1, 2));
            Console.WriteLine(byte2 + " -> " + Convert.ToString(byte2, 2));

            Console.WriteLine(int1 + " -> " + Convert.ToString(int1, 2));
            Console.WriteLine(int2 + " -> " + Convert.ToString(int2, 2));

            Console.WriteLine(long1 + " -> " + Convert.ToString(long1, 2));
            Console.WriteLine(long2 + " -> " + Convert.ToString(long2, 2));

            Console.WriteLine(char1 + " -> " + Convert.ToString(char1, 2));
            Console.WriteLine(char2 + " -> " + Convert.ToString(char2, 2));
        }
    }
}

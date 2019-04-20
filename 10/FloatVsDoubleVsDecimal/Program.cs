using System;

namespace FloatVsDoubleVsDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] floats = new float[] { 2.342f, 9.326f, 3.445f, 5.713f, 2.458f, 3.689f, 10.121f, 4.786f, 6.664f, 18.341f, 0.123f };

            float averageFloat = GetAverage(floats);

            Console.WriteLine($"Average in float: {averageFloat:R}");

            double[] doubles = new double[] { 2.342, 9.326, 3.445, 5.713, 2.458, 3.689, 10.121, 4.786, 6.664, 18.341, 0.123 };

            double averageDouble = GetAverage(doubles);

            Console.WriteLine($"Average in double: {averageDouble:R}");

            decimal[] decimals = new decimal[] { 2.342m, 9.326m, 3.445m, 5.713m, 2.458m, 3.689m, 10.121m, 4.786m, 6.664m, 18.341m, 0.123m };

            decimal averageDecimal = GetAverage(decimals);

            Console.WriteLine($"Average in decimal: {averageDecimal}");
        }

        static float GetAverage(float[] floats)
        {
            float sum = 0;
            foreach (float f in floats)
            {
                sum += f;
            }

            return sum / floats.Length;
        }

        static double GetAverage(double[] doubles)
        {
            double sum = 0;
            foreach (double d in doubles)
            {
                sum += d;
            }

            return sum / doubles.Length;
        }

        static decimal GetAverage(decimal[] decimals)
        {
            decimal sum = 0;
            foreach (decimal d in decimals)
            {
                sum += d;
            }

            return sum / decimals.Length;
        }
    }
}

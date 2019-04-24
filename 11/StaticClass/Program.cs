using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double centimeters = UnitConverter.GetCentimetersFromInches(1.24);
            double feet = UnitConverter.GetFeetFromInches(12);
            double inches = UnitConverter.GetInchesFromCentimeters(5.7);
            double meters = UnitConverter.GetMetersFromCentimeters(254.92);

            Console.WriteLine(centimeters);
            Console.WriteLine(feet);
            Console.WriteLine(inches);
            Console.WriteLine(meters);
        }
    }
}

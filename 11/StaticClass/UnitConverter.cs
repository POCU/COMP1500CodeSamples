using System;

namespace StaticClass
{
    public static class UnitConverter
    {
        public static double GetInchesFromCentimeters(double centimeters)
        {
            return centimeters / 0.393701;
        }

        public static double GetCentimetersFromInches(double inches)
        {
            return inches * 0.393701;
        }

        public static double GetMetersFromCentimeters(double centimeters)
        {
            return centimeters / 100;
        }

        public static double GetFeetFromInches(double inches)
        {
            return inches / 12;
        }

        //public void SomeMethod()
        //{
        //    Console.WriteLine("Won't compile!");
        //}
    }
}

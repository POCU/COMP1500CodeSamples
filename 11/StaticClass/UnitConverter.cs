using System;

namespace StaticClass
{
    public static class UnitConverter
    {
        public static double ToInches(double centimeters)
        {
            return centimeters / 0.393701;
        }

        public static double ToCentimeters(double inches)
        {
            return inches * 0.393701;
        }

        public static double ToMeters(double centimeters)
        {
            return centimeters / 100;
        }

        public static double ToFeet(double inches)
        {
            return inches / 12;
        }

        //public void SomeMethod()
        //{
        //    Console.WriteLine("Won't compile!");
        //}
    }
}

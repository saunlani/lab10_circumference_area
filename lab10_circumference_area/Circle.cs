using System;
namespace lab10_circumference_area
{
    class Circle
    {
        static double pi = Math.PI;

        public double Radius { get; private set; }
        public static int Count { get; private set; }

        public static string CalculateFormattedCircumference(double radius)
        {
            Count = Count + 1;
            return CalculateCircumference(radius).ToString("#.##");
        }

        public static double CalculateCircumference(double radius = 0)
        {
            
            double circumference = (radius * pi) * 2;
            return circumference;
        }


        public static double CalculateArea(double radius)
        {
            double area = pi * (radius * radius);
            return area;
        }

        public static string CalculateFormattedArea(double radius)
        {
            return CalculateArea(radius).ToString("#.##");
        }
    }
}

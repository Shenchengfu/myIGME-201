using System;

namespace UT1Q3
{
    public delegate double round(double x, int y);
    class Demo
    {
        public static double round(double value, int digit)
        {
            return Math.Round(value, digit);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

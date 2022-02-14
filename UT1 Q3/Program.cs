using System;

namespace UT1Q3
{
    delegate double round(double x, int y);
    class Demo
    {
        public static double round(double value, int digit)
        {
            return Math.round(value, digit);
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

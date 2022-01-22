using System;

namespace PE4Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 0;
            int var2 = 0;
            bool flag1 = true;
            bool flag2 = true;
            bool flag3 = true;

            do
            {
                do
                {
                    Console.WriteLine("Please enter the first number");
                    if (Int32.TryParse(Console.ReadLine(), out var1))
                    {
                        flag1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Not an integer.");
                    }
                } while (flag1);

                do
                {
                    Console.WriteLine("Please enter the second number");
                    if (Int32.TryParse(Console.ReadLine(), out var2))
                    {
                        flag2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Not an integer.");
                    }
                } while (flag2);
                if (((var1 > 10) && (var2 < 10)) || ((var1 < 10) && (var2 > 10)))
                {
                    Console.WriteLine("The numbers you entered are {0} and {1}", var1, var2);
                    flag3 = false;
                }
                else
                {
                    Console.WriteLine("please enter 2 new number");
                    {
                        flag1 = true;
                        flag2 = true;
                    }
                }
            } while (flag3);
        }
    }
}

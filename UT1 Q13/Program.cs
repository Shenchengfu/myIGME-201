using System;

namespace UT1Q13
{
    class Program
    {
        public struct employee
        {
            public string sName;
            public double dSalary;
        }

        static string sName = "ShenCheng";
        static double dSalary = 30000;

        public static void Main(string[] args)
        {
            employee ShenCheng;
            ShenCheng.sName = "ShenCheng";
            ShenCheng.dSalary = 30000;

            string inputName = "";

            Console.WriteLine("Please input the user's name: ");
            inputName = Console.ReadLine();

            if (GiveRaise(ShenCheng))
            {
                Console.WriteLine("Congratuations " + sName + "!");
            }
        }

        public static bool GiveRaise(employee e)
        {
            if (e.sName == sName)
            {
                dSalary += 19999.99;
            }
            return e.sName == sName;
        }
    }
}

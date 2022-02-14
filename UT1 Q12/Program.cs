using System;

namespace UT1Q12
{
    public class Program
    {
        static string sName = "Shencheng";
        static double dSalary = 30000;

        public static void Main(string[] args)
        {

            string inputName = "";

            Console.WriteLine("Please input the user's name: ");
            inputName = Console.ReadLine();

            if (GiveRaise(inputName, ref dSalary))
            {
                Console.WriteLine("Congratuations " + sName + "!");
            }
        }

        public static bool GiveRaise(string name, ref double salary)
        {
            if (name == sName)
            {
                dSalary += 19999.99;
            }
            return name == sName;
        }
    }
}

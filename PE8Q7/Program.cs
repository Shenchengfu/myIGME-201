using System;

namespace PE8Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string: ");
            string myStr = Console.ReadLine();

            int len = myStr.Length;
            for (int counter = len - 1; counter >= 0; counter--)
            {
                Console.Write(myStr[counter].ToString());
            }
        }
    }
}

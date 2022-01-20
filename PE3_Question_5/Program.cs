using System;

namespace PE3_Question_5
{
    // Author: Shencheng Fu
    // Purpose: Question 5 for PE 3.
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Obtains four int values from the user and displays the product.
        // Restrictions: None.
        static void Main(string[] args)
        {
            int product = 1;
            int iNum = 0;
            int count = 0;

            while(count < 4)
            {
                Console.WriteLine("Please enter the an integer.");
                if (Int32.TryParse(Console.ReadLine(), out iNum))
                {
                    product *= iNum;
                }
                else
                {
                    Console.WriteLine("Not an integer.");
                    count--;
                }
                count++;
            }
            Console.WriteLine("The product of these four integers is {0}.",product);
        }
    }
}

using System;

namespace PE8Q9
{
    // Author: Shencheng Fu
    // Purpose: Question 9 for PE 8.
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: places double quotes around each word in a string
        // Restrictions: None.
        static void Main(string[] args)
        {
            Console.WriteLine("Please write something");

            string myStr = Console.ReadLine();
            string[] words = myStr.Split(' ');
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                result += ("\"" + words[i] + "\"");
            }
            Console.WriteLine(result);
        }
    }
}

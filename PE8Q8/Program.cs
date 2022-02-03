using System;
using System.Text.RegularExpressions;

namespace PE8Q7
{
    // Author: Shencheng Fu
    // Purpose: Question 8 for PE 8.
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Replace No with Yes.
        // Restrictions: None.
        static void Main(string[] args)
        {
            Console.WriteLine("Please write something: ");

            string myStr = Console.ReadLine();

            string pattern = @"\bno\b";
            string replace = "yes";
            string replacement1 = Regex.Replace(myStr, pattern, replace);
            pattern = @"\bNo\b";
            replace = "Yes";
            string replacement2 = Regex.Replace(replacement1, pattern, replace);
            Console.WriteLine(replacement2);
        }
    }
}

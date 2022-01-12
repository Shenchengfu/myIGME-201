using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    static class Program
    {
        //Method: main
        //Purpose: to print characters in the consoler
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 7)
            {
                i++;
            }
            Console.WriteLine($"There are {i} days in a week!");
        }
    }
}

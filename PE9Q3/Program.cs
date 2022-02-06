using System;

namespace PE9Q3
{
    class Program
    {
        delegate string ReadLineDelegate();
        static void Main(string[] args)
        {
            ReadLineDelegate readLine = new ReadLineDelegate(Console.ReadLine);
            Console.WriteLine("Type a string:");
            string userInput = readLine();
            Console.WriteLine("You typed: {0}", userInput);
        }
    }
}

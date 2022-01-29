using System;
using System.IO;
using System.Collections.Generic;


namespace PE_7_Mad_Libs
{
    // Class Program
    // Author: Shencheng Fu 
    // Purpose: Mad Libs game
    // Restrictions: None
    class Program
    {
        static void Main(string[] args)
        {
            // Method: Main
            // Purpose: let the user to enter words to form a complete story
            // Restrictions: None

            // declare variables
            List<string> storys = new List<string>();
            List<string> resultString = new List<string>();
            int chosenStory = 0;
            int i = 0;
            string userName = null;
            bool valid = false;

            // ask if the user want to play the game
            Console.WriteLine("Do you want to play Mad Libs?");
            while (valid == false)
            {
                Console.WriteLine("Please answer 'yes' or 'no'.");
                string answer = Console.ReadLine();
                if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    valid = true;
                    // read lines from the MadLibsTemplate file 
                    // and store all lines into a string array
                    StreamReader input = null;
                    try
                    {
                        input = new StreamReader("MadLibsTemplate.txt");
                        string line = null;
                        while ((line = input.ReadLine()) != null)
                        {
                            storys.Add(line);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error with file: " + e.Message);
                    }

                    finally
                    {
                        if (input != null)
                        {
                            input.Close();
                        }
                    }

                    // ask the user to enter name and choose a story 
                    Console.WriteLine("Please enter your name: ");
                    userName = Console.ReadLine();
                    Console.WriteLine("Please choose a number from 1 - {0}", storys.Count);
                    while (!(Int32.TryParse(Console.ReadLine(), out chosenStory) && chosenStory > 0 && chosenStory < storys.Count))
                    {
                        Console.WriteLine("Please choose a number from 1 - {0}", storys.Count);
                    }

                    // prompt the user to enter words and store the input 
                    string[] words = storys[chosenStory - 1].Split(" ");
                    for (i = 0; i < words.Length; i++)
                    {
                        if (words[i].StartsWith("{"))
                        {
                            Console.WriteLine($"Please enter a {words[i]}");
                            words[i] = Console.ReadLine();
                            words[i].Replace("_", " ");
                        }
                    }

                    // push the final story to resultString and print it 
                    for (i = 0; i < words.Length; i++)
                    {
                        resultString.Add(words[i]);

                        if (resultString[i] == @"\n")
                        {
                            // start a new line when see \n
                            resultString[i] = "\n";
                            Console.Write(resultString[i]);
                        }
                        else
                        {
                            Console.Write(resultString[i] + " ");
                        }
                    }
                }
                else if (answer.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Thanks and good bye.");
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            }
        }
    }
}
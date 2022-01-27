using System;


namespace PE6
{
    // Class Program
    // Author: Shencheng Fu 
    // Purpose: Number guessing game
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: generate a random integer between 0 and 100
        // let the use have 8 guesses what the is
        // Restrictions: None
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);
            int i = 0;
            int userGuess = 0;
            int turn = 1;

            Console.WriteLine(randomNumber);
            Console.WriteLine("Please take guesses between 0 and 100.");
            // print the number on the console window

            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Turn #{0}: Enter your guess: ", turn);
                if (Int32.TryParse(Console.ReadLine(), out userGuess) && (userGuess >= 0 && userGuess <= 100))
                {
                    // tell if the guess is too high or too low
                    if (userGuess > randomNumber)
                    {
                        Console.WriteLine("Too high");
                                            turn++;
                    }
                    else if (userGuess < randomNumber)
                    {
                        Console.WriteLine("Too low");
                        turn++;
                    }
                    else
                    {
                        // exit the loop if the guess is right
                        i = 8;
                    }
                }
                // caution if the input is invalid
                else
                {
                    Console.WriteLine("Invalid guess – try again");
                    i--;
                }
            }

            if (turn < 9)
            {
                // print the turns user used
                Console.WriteLine("");
                Console.WriteLine("Correct! You won in {0} turns.", turn);
            }
            else
            {
                // print the number if user failed
                Console.WriteLine("");
                Console.WriteLine("You ran out of turns. The number was {0}.", randomNumber);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbiesProgram
{
    class Program
    {
        static void PlayGame(object obj)
        {
            if (obj is BoardGame)
            {
                Console.WriteLine("Your choice is board game!");
                ((BoardGame)obj).StartGame();
                ((BoardGame)obj).ExchangeMerch();
            }
            else if (obj is ConsoleGame)
            {
                Console.WriteLine("Your choice is console game!");
                ((ConsoleGame)obj).StartGame();
                ((ConsoleGame)obj).ChangeResolution();

            }
        }
        static void Main(string[] args)
        {
            BoardGame bg = new BoardGame();
            ConsoleGame cg = new ConsoleGame();
            PlayGame(bg);
            PlayGame(cg);
        }
    }
}

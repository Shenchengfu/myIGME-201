using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbiesProgram
{
    public class ConsoleGame : Game, GameInterface
    {
        public string consoleType;

        public char difficulty;

        public int numLevels;

        public void ChangeResolution()
        {
        }

        public override void EndGame()
        {
        }

        public override void InviteFriends()
        {
        }

        public override void StartGame()
        {
        }

        public void StartMultiplayer()
        {
        }

        public override void WriteScores()
        {
            Console.WriteLine("...Printing all socres for this board game...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbiesProgram
{
    public class BoardGame : Game, GameGadgets
    {
        public string boardType;

        public bool ancientGame;

        public int maxPlayers;

        public void BuyGadgets()
        {
        }


        public override void EndGame()
        {
        }

        public void ExchangeMerch()
        {

        }

        public override void InviteFriends()
        {
        }

        public override void StartGame()
        {
        }


        public override void WriteScores()
        {
            Console.WriteLine("...Printing all socres for this board game...");
        }
    }
}

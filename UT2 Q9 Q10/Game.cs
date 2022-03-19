using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbiesProgram
{
    public abstract class Game
    {
        private string gameTitle;
        private string gameDescription;
        public int yearReleased;
        public double initialPrice;
        public bool availableOnline;

        public string GameTitle
        {
            get
            {
                return gameTitle;
            }
        }

        public string GameDescription
        {
            get
            {
                return gameDescription;
            }
        }

        public abstract void StartGame();

        public abstract void InviteFriends();

        public abstract void EndGame();


        public virtual void WriteScores() { }


    }
}

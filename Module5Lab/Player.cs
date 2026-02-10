using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Module5Lab
{
    internal class Player
    {
        private string name;

        private int score;

        private int livesLeft;


        public Player()
        {
        }    

        public Player(string name)
        {
            this.name = name;
        }

        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;
        }

        public int GetScore()
        {
            return score;
        }
//method for adding points to players score
        public void AddPoints(int totalPoints)
        {//increment score by total points passed to the method
            score += totalPoints;
        }

//method for killing the player in the game
        public void Kill()
        {
            // We make sure they can't get negative lives.
            if (livesLeft > 0)
            {
                livesLeft--;

            }
        }

        public int GetLivesLeft()
        {
            return livesLeft;
        }

    } //end class
} //end namespace
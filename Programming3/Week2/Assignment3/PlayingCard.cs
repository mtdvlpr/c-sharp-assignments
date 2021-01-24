using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class PlayingCard
    {
        public uint rank;
        public CardSuit suit;

        public PlayingCard(uint rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            string rankString;
            switch (rank)
            {
                case 11:
                    rankString = "Jack";
                    break;
                case 12:
                    rankString = "Queen";
                    break;
                case 13:
                    rankString = "King";
                    break;
                case 14:
                    rankString = "Ace";
                    break;
                default:
                    rankString = rank.ToString();
                    break;
            }
            return rankString + " of " + suit;
        }
    }
}

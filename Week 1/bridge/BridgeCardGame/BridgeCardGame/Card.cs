using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeCardGame
{
    public enum eSuit  { CLUBS = 1, SPADES = 2, DIAMONDS = 3, HEARTS = 4 }
    public enum eRank { ACE = 1, TWO = 2, THREE = 3, FOUR = 4, FIVE = 5, SIX = 6, SEVEN = 7, EIGHT = 8, NINE = 9, TEN = 10, JACK = 11, QUEEN = 12, KING = 13 }

    class Card
    {
        private eRank rank;
        private eSuit suit;

        public Card(eRank rank, eSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString() {
 	        return base.ToString();
        }

        

    }
}

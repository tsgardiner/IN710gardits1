using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeCardGame
{
    class Deck
    {
        const int NCARDS = 52;
        const int NSUITS = 4;
        const int NRANKS = 13;

        private Card[,] cards;
        private Random rand;

        public Deck(Random rand)
        {
            cards = new Card[NRANKS, NSUITS];

            for (int i = 0; i < length; i++)
            {
                
            }
        }

    }
}

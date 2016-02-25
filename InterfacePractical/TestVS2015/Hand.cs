using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestVS2015
{
    public class Hand: IComparable<Card>
    {
        public List<Card> CardsInHand { get; set; }
        public int TotalHCP
        {
            get; set;
        }

        public Hand()
        {
            CardsInHand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);
        }

        public int ComputeHCP()
        {
            TotalHCP = 0;
            foreach (Card c in CardsInHand)
                TotalHCP += c.HCP;

            return 0;
        }


        public int SortHand()
        {
            

            return 0;
        }

        
        public int CompareTo(Card other, Card otherother)
        {
            if ((other.Suit < otherother.Suit) && (other.Rank < otherother.Rank))
                return 1;
            if ((other.Suit > otherother.Suit) && (other.Rank > otherother.Rank))
                return -1;
            else
            return 0;
        }
    }
}
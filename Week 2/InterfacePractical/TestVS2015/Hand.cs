﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestVS2015
{
    public class Hand: IComparable
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
            CardsInHand.Sort();
            return 0;
        }

        public int CompareTo(object obj)
        {
            int myHCP = TotalHCP;
            int otherHCP = (obj as Hand).TotalHCP;

            if (myHCP == otherHCP)
                return 0;
            else if (myHCP < otherHCP)
                return 1;
            else
                return -1;
        }
    }
}
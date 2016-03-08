using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BridgeDealer
{
    public class CDealer
    {
        private const int playerCount = 4;
        private CDeck cards;
        private CHand[] playerHands;     

        public CDealer()
        {
            cards = new CDeck();
            playerHands = new CHand[playerCount]; //initialize the playerHands array.

            for (int i = 0; i < playerCount; i++) //create a new CHand object for all the playerHands in the playerHands array.
                playerHands[i] = new CHand();
        }

        //Original display method
        public void Deal(ListBox lb)
        {
            cards.ShuffledHands(playerHands); //shuffles all the playerHands cards.

            lb.Items.Clear();

            for (int i = 0; i < playerHands.Length; i++)
            {
                lb.Items.Add(((Player)(i)).ToString()); //adds the player position on the table (based on the enumerator)
                lb.Items.Add("");

                for (int j = 0; j < playerHands[i].Hand.Length; j++)
                    lb.Items.Add(playerHands[i].Hand[j].ToString()); //adds each of the playerHands cards to the list box.

                lb.Items.Add("");
                lb.Items.Add("HCP: " + playerHands[i].TotalPoints().ToString()); //outputs the playerHands high card point score.
                lb.Items.Add("-----------");
            }
        }


        //Bridge Display change
        public void DealVariation(ListBox lb)
        {
            String[] spades     = new String[playerCount];
            String[] hearts     = new String[playerCount];
            String[] diamonds   = new String[playerCount];
            String[] clubs      = new String[playerCount];
            int enumIndexValue;

            cards.ShuffledHands(playerHands);  
            lb.Items.Clear();

            for (int i = 0; i < playerHands.Length; i++)
            {
                spades[i]   += "S:\t";
                hearts[i]   += "H:\t";
                diamonds[i] += "D:\t";
                clubs[i]    += "C:\t";

                for (int j = 0; j < playerHands[i].Hand.Length; j++)
			{
			       switch (playerHands[i].Hand[j].Suit) //ace, king, queen and jack are the only cards worth high card points.
                    {
                    case SuitValue.SPADES:
                        enumIndexValue = (int) playerHands[i].Hand[j].Number;                         
                        spades[i] += cardValueChange(enumIndexValue);
                        break;
                    case SuitValue.HEARTS:
                        enumIndexValue = (int)playerHands[i].Hand[j].Number;
                        hearts[i] += cardValueChange(enumIndexValue);
                        break;
                    case SuitValue.DIAMONDS:
                        enumIndexValue = (int)playerHands[i].Hand[j].Number;
                        diamonds[i] += cardValueChange(enumIndexValue);
                        break;
                    case SuitValue.CLUBS:
                        enumIndexValue = (int)playerHands[i].Hand[j].Number;
                        clubs[i] += cardValueChange(enumIndexValue);
                        break;
                }                  

			}
                lb.Items.Add(spades[i]);
                lb.Items.Add(hearts[i]);
                lb.Items.Add(diamonds[i]);
                lb.Items.Add(clubs[i]);
                lb.Items.Add("");
                lb.Items.Add("HCP: " + playerHands[i].TotalPoints().ToString()); //outputs the playerHands high card point score.
                lb.Items.Add("-----------");
                lb.Items.Add("");
            } 
        }

        //Takes current enum location and returns a string.
        public String cardValueChange(int eLocation)
        {
            String[] cardNames = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K" };

            return cardNames[eLocation];            
        }
    }
}

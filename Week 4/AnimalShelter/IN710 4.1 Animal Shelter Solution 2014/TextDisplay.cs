using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {
        /* YOUR CODE HERE */
        public static ListBox listBox;

        public TextDisplay(ListBox listbox)
        {
            listBox = listbox;
        }

        public void displayCritterList(List<Critter> critterList)
        {
            for (int i = 0; i < critterList.Count; i++)
            {
                listBox.Items.Add(critterList[i].Name + " the " + critterList[i].Species); 
            }
        }

        public void clearDisplay()
        {
            listBox.Items.Clear();
        }
    }
}

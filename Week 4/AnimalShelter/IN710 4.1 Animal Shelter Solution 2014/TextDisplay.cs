﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {
        /* YOUR CODE HERE */
        private ListBox listBox;

        public TextDisplay(ListBox listbox)
        {
            listBox = listbox;
        }

        public void displayCritterList(List<Critter> critterList)
        {
            throw new NotImplementedException();
        }

        public void clearDisplay()
        {
            throw new NotImplementedException();
        }
    }
}

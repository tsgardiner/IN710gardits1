﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay: IDisplay
    {
       /* YOUR CODE HERE */
        List<PictureBox> PictureBoxList;

        public PictureDisplay (List<PictureBox> pictureBoxList)
        {
            PictureBoxList = pictureBoxList;
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

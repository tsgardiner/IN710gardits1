using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class PetrolBot
    {
        Graphics botCanvas;
        Color botColour;
        Brush botBrush { get; set; }
        Point botLocation;
        Ship botShip;
        Point waitingLocation;
        Point shipLocation;
        int botSize;

        public PetrolBot(Graphics botCanvas, Color botColour, Point botLocation, int botSize)
        {
            this.botCanvas = botCanvas;
            this.botColour = botColour;
            this.botLocation = botLocation;
            this.waitingLocation = botLocation;
            this.botSize = botSize;

            botBrush = new SolidBrush(botColour);
        }

        public void DrawBot()
        {
            botCanvas.FillEllipse(botBrush, waitingLocation.X, waitingLocation.Y, botSize, botSize);
        }
    }
}

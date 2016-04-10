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

        public PetrolBot(Graphics botCanvas, Color botColour, Point botLocation, int botSize, Ship ship)
        {
            this.botCanvas = botCanvas;
            this.botColour = botColour;
            this.botLocation = botLocation;
            this.waitingLocation = botLocation;
            this.botSize = botSize;

            botBrush = new SolidBrush(botColour);

            this.botShip = ship;

            Ship.OutOfFuelEvent outOfFuelHandler = new Ship.OutOfFuelEvent(OutOfFuelHandler);

            ship.outOfFuel += outOfFuelHandler;
        }

        public void DrawBot()
        {
            botCanvas.FillEllipse(botBrush, botLocation.X, botLocation.Y, botSize, botSize);
        }

        public void OutOfFuelHandler(object subject, ShipEvent se)
        {
            botLocation = botShip.ShipLocation;
            botShip.ShipState = EShipState.Refueling;
        }
    }
}

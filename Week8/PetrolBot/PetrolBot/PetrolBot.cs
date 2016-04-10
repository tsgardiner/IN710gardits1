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
            Ship.FullOfFuelEvent fullOfFuelHandler = new Ship.FullOfFuelEvent(FullOfFuelHandler);

            ship.outOfFuel += outOfFuelHandler;
            ship.fullOfFuel += fullOfFuelHandler;
        }

        public void DrawBot()
        {
            botCanvas.FillEllipse(botBrush, botLocation.X, botLocation.Y, botSize, botSize);
        }

        public void OutOfFuelHandler(object subject, ShipEvent se)
        {
            botShip.ShipState = EShipState.Refueling;
            botLocation = botShip.ShipLocation;            
        }

        public void FullOfFuelHandler(object subject, ShipEvent se)
        {
            botShip.ShipState = EShipState.Wandering;
            botLocation = waitingLocation;            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public enum EShipState { Wandering, Refueling }

    public class Ship
    {
        const int PETROL_AMOUNT = 100;

        public delegate void FullOfFuelEvent(object subject, ShipEvent se);
        public delegate void OutOfFuelEvent(object subject, ShipEvent se);

        int petrol = PETROL_AMOUNT;         
        Random rGen;
        Graphics shipCanvas;
        Brush ShipBrush { get; set; } 
        Color shipColour;
        Point shipLocation;
        int shipSize;
        EShipState shipState;
        int shipVelocity;

        public Ship(Graphics shipCanvas, Color shipColour, Point shipLocation, int shipSize)
        {
            this.shipCanvas = shipCanvas;
            this.shipColour = shipColour;
            this.shipSize = shipSize;
            ShipLocation = shipLocation;
            shipState = EShipState.Wandering;

            rGen = new Random();
            ShipBrush = new SolidBrush(shipColour);
        }

        public void ShipCycle()
        {
            DrawShip();

            if (Petrol == 0)
            {
                shipState = EShipState.Refueling;
            }

            if (shipState == EShipState.Wandering)
            {
                MoveShip();                
                ShipColourTransition();
                UsePetrol();
            }
           
        }

        public void DrawShip()
        {
            shipCanvas.Clear(SystemColors.Control);
            shipCanvas.FillRectangle(ShipBrush, ShipLocation.X, ShipLocation.Y, shipSize, shipSize);    
        }

        public void MoveShip()
        {
            shipLocation.X++;
            shipLocation.Y++;
        }

        public void ShipColourTransition()
        {
            
            double petrolLevel = Petrol / 100.0;
            double emptyRGB = (255 * petrolLevel);
            shipColour = Color.FromArgb(255, (int)emptyRGB, 0, 0);
            ShipBrush = new SolidBrush(shipColour);
                        
        }

        public void OnFullOfFuelEvent()
        {

        }

        public void OnOutOfFuelEvent()
        {

        }

        public void Refuel()
        {
            Petrol++;
        }

        public void UsePetrol()
        {
            if (Petrol != 0)
            {
                Petrol--;  
            }            
        }

        public int Petrol
        {
            get { return petrol; }
            set { petrol = value; }
        } 
        public Point ShipLocation
        {
            get { return shipLocation; }
            set { shipLocation = value; }
        }
    }
}

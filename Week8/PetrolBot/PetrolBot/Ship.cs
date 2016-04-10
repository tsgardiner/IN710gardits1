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
        public event FullOfFuelEvent fullOfFuel;
        public event OutOfFuelEvent outOfFuel;

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

            //if (Petrol == 0)
            //{
            //    ShipState = EShipState.Refueling;
            //}
            //else if (Petrol == 100)
            //{
            //    ShipState = EShipState.Wandering;
            //}


            if (ShipState == EShipState.Wandering)
            {
                MoveShip();                
                ShipColourTransition();
                UsePetrol();
            }

            if (ShipState == EShipState.Refueling)
            {
                Refuel();
                ShipColourTransition();
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
            double rgb = (255 * petrolLevel);
            int currentColorValue = (int)rgb;
            shipColour = Color.FromArgb(255, currentColorValue, 0, 0);
            ShipBrush = new SolidBrush(shipColour);               
        }

        public void OnFullOfFuelEvent(Point location)
        {
            ShipEvent se = new ShipEvent(location);

            if (fullOfFuel != null)
            {
                fullOfFuel(this, se);
            }
        }

        public void OnOutOfFuelEvent(Point location)
        {
            ShipEvent se = new ShipEvent(location);

            if (outOfFuel != null)
            {
                outOfFuel(this, se);
            }
        }

        public void Refuel()
        {
            Petrol++;
        }

        public void UsePetrol()
        {
            Petrol--;              
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
        public EShipState ShipState
        {
            get { return shipState; }
            set { shipState = value; }
        }
    }
}

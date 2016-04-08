﻿using System;
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

        int petrol;         
        Random rGen;
        Graphics shipCanvas;
        Brush shipBrush;
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

            rGen = new Random();
            shipBrush = new SolidBrush(shipColour);
        }

        public void ShipCyle()
        {
            DrawShip();
            MoveShip();
            UsePetrol(); 
        }

        public void DrawShip()
        {
            shipCanvas.Clear(SystemColors.Control);
            shipCanvas.FillRectangle(shipBrush, ShipLocation.X, ShipLocation.Y, shipSize, shipSize);    
        }

        public void MoveShip()
        {
            shipLocation.X++;
            shipLocation.Y++;
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
    }
}

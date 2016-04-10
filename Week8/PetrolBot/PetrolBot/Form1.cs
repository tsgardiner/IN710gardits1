using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBot
{
    public partial class Form1 : Form
    {

        
        List<Ship> shipList;
        List<PetrolBot> botList;

        Graphics canvas;
        Ship ship;
        PetrolBot bot;
        Point shipPosition, botPosition;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = CreateGraphics();
            shipPosition = new Point(50, 50);
            botPosition = new Point(50, 420);
            
            ship = new Ship(canvas, Color.Red, shipPosition, 50);
            bot = new PetrolBot(canvas, Color.Blue, botPosition, 20, ship);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ship.ShipCycle();
            bot.DrawBot();

            if (ship.Petrol == 100)
            {
                ship.OnFullOfFuelEvent(ship.ShipLocation);
            }
            if (ship.Petrol == 0)
            {
                ship.OnOutOfFuelEvent(ship.ShipLocation);
            }
            
            
        }
    }
}

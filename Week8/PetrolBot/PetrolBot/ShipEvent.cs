using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class ShipEvent : EventArgs
    {
        Point shipLocation;

        public ShipEvent(Point shipLocation)
        {
            this.shipLocation = shipLocation;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    public class Monitor : Component
    {
        protected string size;
        public override string ToString()
        {
            return price.ToString() + "\t" + name + " " + size + " Monitor";
        }
    }

    public class GamingMonitor : Monitor
    {
        public GamingMonitor()
        {
            name = "ASUS";
            size = "27'";
            price = 600;
        }
    }

    public class BusinessMonitor : Monitor
    {
        public BusinessMonitor()
        {
            name = "Dell";
            size = "24'";
            price = 400;
        }
    }

    public class MultimediaMonitor : Monitor
    {
        public MultimediaMonitor()
        {
            name = "AOC";
            size = "32'";
            price = 700;
        }
    }
}

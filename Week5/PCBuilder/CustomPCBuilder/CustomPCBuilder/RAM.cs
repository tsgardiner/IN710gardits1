using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    public class RAM : Component
    {
        protected string freq;
    }

    public class GamingRAM : RAM
    {
        public GamingRAM()
        {            
            price = 800;
            freq = "3200MHz";
        }
    }

    public class BusinessRAM : RAM
    {
        public BusinessRAM()
        {           
            price = 400;
            freq = "2400MHz";
        }
    }

    public class MultimediaRAM : RAM
    {
        public MultimediaRAM()
        {           
            price = 250;
            freq = "1800MHz";
        }
    }
}

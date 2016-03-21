using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    public abstract class RAM : Component
    {
        protected string freq;

        public override string ToString()
        {
            return price.ToString() + "\t" + name + " RAM at " + freq;
        }
    }

    public class GamingRAM : RAM
    {
        public GamingRAM()
        {
            name = "32GB";
            price = 800;
            freq = "3200MHz";
        }
    }

    public class BusinessRAM : RAM
    {
        public BusinessRAM()
        {
            name = "16GB";
            price = 400;
            freq = "2400MHz";
        }
    }

    public class MultimediaRAM : RAM
    {
        public MultimediaRAM()
        {
            name = "8GB";
            price = 250;
            freq = "1800MHz";
        }
    }
}

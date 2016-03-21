using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    public abstract class CPU : Component
    {
        protected string cores;
        protected double ghz;

        public override string ToString()
        {
            return price.ToString() +"\t"+ name +" "+ cores +" core at " + ghz + " GHz";
        }

    }

    public class GamingCPU : CPU
    {
        public GamingCPU()
        {
            name = "i7 4790K";
            price = 500;
            cores = "Quad";
            ghz = 4.8;                        
        }
    }

    public class BusinessCPU : CPU
    {
        public BusinessCPU()
        {
            name = "i5 4690";
            price = 300;
            cores = "Quad";
            ghz = 3.9;                      
        }
    }

    public class MultimediaCPU : CPU
    {
        public MultimediaCPU()
        {
            name = "i3 4330";
            price = 150;
            cores = "Dual";
            ghz = 3.5;                        
        }
    }

}

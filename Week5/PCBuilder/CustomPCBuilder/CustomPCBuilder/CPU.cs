using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    public class CPU : Component
    {
        public CPU(string name, double price)
            :base(name, price)
        {
            
        }
    }

    public class GamingCPU : CPU
    {
        public GamingCPU(string name, double price)
            :base(name, price)
        {

        }
    }

}

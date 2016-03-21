using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    public interface IComponentsFactory
    {
        CPU createCPU();
        GPU createGPU();
        RAM createRAM();
    }
}

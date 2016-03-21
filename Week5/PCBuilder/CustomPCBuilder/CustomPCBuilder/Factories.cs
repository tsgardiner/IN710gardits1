using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    public class GamingFactory : IComponetsFactory
    {

        public CPU createCPU()
        {
            throw new NotImplementedException();
        }

        public GPU createGPU()
        {
            throw new NotImplementedException();
        }

        public RAM createRAM()
        {
            throw new NotImplementedException();
        }
    }
}

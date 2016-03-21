using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    

    public class GamingFactory : IComponetsFactory
    {

        GPU gpu = null;
        CPU cpu = null;
        RAM ram = null;
        
        public CPU createCPU()
        {
           return cpu = new GamingCPU();
        }

        public GPU createGPU()
        {
            return gpu = new GamingGPU();
        }

        public RAM createRAM()
        {
            return ram = new GamingRAM();
        }
    }

    public class BusinessFactory : IComponetsFactory
    {
        GPU gpu = null;
        CPU cpu = null;
        RAM ram = null;

        public CPU createCPU()
        {
            return cpu = new BusinessCPU();
        }

        public GPU createGPU()
        {
            return gpu = new BusinessGPU();
        }

        public RAM createRAM()
        {
            return ram = new BusinessRAM();
        }
    }

    public class MultimediaFactory : IComponetsFactory
    {
        GPU gpu = null;
        CPU cpu = null;
        RAM ram = null;

        public CPU createCPU()
        {
            return cpu = new MultimediaCPU();
        }

        public GPU createGPU()
        {
            return gpu = new MultimediaGPU();
        }

        public RAM createRAM()
        {
            return ram = new MultimediaRAM();
        }
    }
}

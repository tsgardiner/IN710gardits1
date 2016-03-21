using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    

    public class GamingFactory : IComponentsFactory
    {

        GPU gpu = null;
        CPU cpu = null;
        RAM ram = null;
        Monitor monitor = null;
        
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

        public Monitor createMonitor()
        {
            return monitor = new GamingMonitor();
        }
    }

    public class BusinessFactory : IComponentsFactory
    {
        GPU gpu = null;
        CPU cpu = null;
        RAM ram = null;
        Monitor monitor = null;

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
        
        public Monitor createMonitor()
        {
            return monitor = new BusinessMonitor();
        }
    }

    public class MultimediaFactory : IComponentsFactory
    {
        GPU gpu = null;
        CPU cpu = null;
        RAM ram = null;
        Monitor monitor = null;

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
        public Monitor createMonitor()
        {
            return monitor = new MultimediaMonitor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPCBuilder
{
    public class GPU : Component
    {
        protected string dedicatedMemory;

    }

        public class GamingGPU : GPU
        {
            public GamingGPU()
            {
                name = "GTX 1080Ti";
                price = 2000;
                dedicatedMemory = "16GB";
            }
        }

        public class BusinessGPU : GPU
        {
            public BusinessGPU()
            {
                name = "GTX 970";
                price = 500;
                dedicatedMemory = "4GB";
            }
        }

        public class MultimediaGPU : GPU
        {
            public MultimediaGPU()
            {
                name = "GTX 960";
                price = 300;
                dedicatedMemory = "4GB";
            }
        }
    
}

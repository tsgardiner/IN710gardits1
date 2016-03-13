using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockApp
{
    class TimeKeeper
    {

        public IClock clockType { get; set; }
        public string currentTime = DateTime.Now.ToString("HH:mm:ss");

        public TimeKeeper()
        {

        }



    }
}

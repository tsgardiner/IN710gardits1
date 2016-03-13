using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClockApp
{
    class TimeKeeper
    {

        public IClock currentClockType { get; set; }        

        public TimeKeeper()
        {

        }

        public void RunClock()
        {            
            currentClockType.On();
            currentClockType.UpdateTimeDisplay(); //Calls update to stop the time from jumping forward onscreen.
            currentClockType.ShowClock();                       
        }

    }
}

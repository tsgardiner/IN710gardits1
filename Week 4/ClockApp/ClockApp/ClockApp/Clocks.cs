using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public class DigitalClock : IClock
    {
        Timer timer;
        Label lbDigitalDisplay;

        public DigitalClock(Timer timer, Label lbDigitalDisplay)
        {
            this.timer = timer;
            this.lbDigitalDisplay = lbDigitalDisplay;
        }

        public void On()
        {
            timer.Start();
        }

        public void Off()
        {
            timer.Stop();
        }

        public void UpdateTimeDisplay()
        {
            lbDigitalDisplay.Text = DateTime.Now.ToLongTimeString();
        }

        public void ShowClock()
        {
            lbDigitalDisplay.Visible = true;
        }

        public void HideClock()
        {
            lbDigitalDisplay.Visible = false;
        }
    }

    public class AnalogClock : IClock
    {
        AnalogClockControl.AnalogClock analogClock;
        Timer timer;

        public AnalogClock(Timer timer, AnalogClockControl.AnalogClock analogClock)
        {
            this.timer = timer;
            this.analogClock = analogClock;            
        }
        
        public void On()
        {
            analogClock.Start();
        }

        public void Off()
        {
            analogClock.Stop();
        }

        public void UpdateTimeDisplay()
        {
            //Not needed. I'm guessing it gets the system time itself.
        }

        public void ShowClock()
        {
            analogClock.Visible = true;
        }

        public void HideClock()
        {
            analogClock.Visible = false;
        }
    }
}

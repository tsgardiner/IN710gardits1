using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        TimeKeeper timekeeper;

        public Form1()
        {
            InitializeComponent();

            timekeeper = new TimeKeeper();
            analogClock1.Visible = false;
            lbDigitalDisplay.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbAnalog.Checked)
            {
                timekeeper.currentClockType = new AnalogClock(timer1, analogClock1);
                lbDigitalDisplay.Visible = false;
            }                
            else
            {
                timekeeper.currentClockType = new DigitalClock(timer1, lbDigitalDisplay);
                analogClock1.Visible = false;
            }

            timekeeper.RunClock();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timekeeper.currentClockType.Off();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timekeeper.currentClockType.UpdateTimeDisplay(); //Completely forgot to turn timer tick event on.
        }
    }
}

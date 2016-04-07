using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicator
{
    public class ProgressSubject
    {
        const int NUM_OF_STEPS = 10;
        Button button;

        public ProgressSubject(Button button)
        {
            this.button = button;

            button.Click += new EventHandler(OnUpdateEvent);
        }

        public void OnUpdateEvent(object subject, EventArgs e)
        {

        }

        public void SlowMethod()
        {
            int count = 0;
            while (count != NUM_OF_STEPS)
            {
                Thread.Sleep(500);
                count++;
            }
        }


        public void updateSpinBox()
        {
            numericUpDown1.Value++;
            Application.DoEvents();
        }

        public void updateProgressBar()
        {
            progressBar1.PerformStep();
        }

        public void updateTrackBar()
        {
            trackBar1.Value++;
        }
    }
}

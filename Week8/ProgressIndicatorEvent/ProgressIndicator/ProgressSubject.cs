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

        public event EventHandler OnUpdateEvent;
        public EventArgs e;

        public ProgressSubject()
        {
            e = new EventArgs();
        }

        public void SlowMethod()
        {
            int count = 0;
            while (count != NUM_OF_STEPS)
            {
                Thread.Sleep(500);
                count++;
                OnUpdateEvent(this, e);
            }
        }
    }
}

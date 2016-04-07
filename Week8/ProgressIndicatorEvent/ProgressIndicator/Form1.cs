using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProgressIndicator
{
    public partial class Form1 : Form
    {
        const int NUM_OF_STEPS = 10;
        public delegate void DFeedBack();
        DFeedBack dfeedback;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            slowMethod(dfeedback);
        }

        public void slowMethod(DFeedBack dfeedback)
        {
            int count = 0;
            while (count != NUM_OF_STEPS)
            {
                Thread.Sleep(500);
                dfeedback();
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

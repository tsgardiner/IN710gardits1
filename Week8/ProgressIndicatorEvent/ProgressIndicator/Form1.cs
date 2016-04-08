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
        
        ProgressSubject progressSubject;
        EventHandler spinBoxHandler, trackBarHandler, progressBarHandler;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressSubject = new ProgressSubject();

            spinBoxHandler = new EventHandler(UpdateSpinBox);
            trackBarHandler = new EventHandler(UpdateTrackBar);
            progressBarHandler = new EventHandler(UpdateProgressBar);

            progressSubject.OnUpdateEvent += spinBoxHandler;
            progressSubject.OnUpdateEvent += progressBarHandler;
            progressSubject.OnUpdateEvent += trackBarHandler;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            progressSubject.SlowMethod();
        }

        public void UpdateSpinBox(object sender, EventArgs e)
        {
            numericUpDown1.Value++;
            Application.DoEvents();
        }

        public void UpdateProgressBar(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        public void UpdateTrackBar(object sender, EventArgs e)
        {
            trackBar1.Value++;
        }
    }
}
